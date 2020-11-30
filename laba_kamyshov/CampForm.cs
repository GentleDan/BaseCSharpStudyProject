using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace laba_kamyshov
{
    public partial class CampForm : Form
    {
        private readonly CampCollection campCollection;

        private readonly Logger logger;

        public CampForm()
        {
            InitializeComponent();
            campCollection = new CampCollection(pictureCampBox.Width, pictureCampBox.Height);
            logger = LogManager.GetCurrentClassLogger();
        }

        private void ReloadLevels()
        {
            int index = listBoxCamp.SelectedIndex;
            listBoxCamp.Items.Clear();
            for (int i = 0; i < campCollection.Keys.Count; i++)
            {
                listBoxCamp.Items.Add(campCollection.Keys[i]);
            }
            if (listBoxCamp.Items.Count > 0 && (index == -1 || index >=
           listBoxCamp.Items.Count))
            {
                listBoxCamp.SelectedIndex = 0;
            }
            else if (listBoxCamp.Items.Count > 0 && index > -1 && index <
           listBoxCamp.Items.Count)
            {
                listBoxCamp.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxCamp.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureCampBox.Width,
               pictureCampBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                campCollection[listBoxCamp.SelectedItem.ToString()].Draw(gr);
                pictureCampBox.Image = bmp;
            }
        }

        private void Button_Add_Camp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewCamp.Text))
            {
                MessageBox.Show("Введите название стоянки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили парковку {textBoxNewCamp.Text}");
            campCollection.AddParking(textBoxNewCamp.Text);
            ReloadLevels();
        }

        private void Button_Del_Camp_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить стоянку {listBoxCamp.SelectedItem.ToString()}?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку{listBoxCamp.SelectedItem.ToString()}");
                    campCollection.DeleteParking(listBoxCamp.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
            if (listBoxCamp.SelectedItem == null)
            {
                pictureCampBox.Image = null;
            }
        }

        private void TakeExcavator_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedIndex > -1 && MaskedBoxPlace.Text != "")
            {
                try
                {
                    Vehicle vehicle = campCollection[listBoxCamp.SelectedItem.ToString()] -
                    Convert.ToInt32(MaskedBoxPlace.Text);
                    if (vehicle != null)
                    {
                        ExcavatorForm form = new ExcavatorForm();
                        form.SetCar(vehicle);
                        Draw();
                        form.ShowDialog();
                        logger.Info($"Изъят автомобиль {vehicle} с места{MaskedBoxPlace.Text}");
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    logger.Warn("Попытка забрать транспорт с незанятого места");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неудачная попытка забрать транспорт со стоянки");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddTransport(Vehicle transport)
        {
            if (transport != null && listBoxCamp.SelectedIndex > -1)
            {
                try
                {
                    if ((campCollection[listBoxCamp.SelectedItem.ToString()]) + transport)
                    {
                        Draw();
                        logger.Info($"Добавлен автомобиль {transport}");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось поставить транспорт");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn("Попытка добавить транспорт в заполненную стоянку");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неудачная попытка добавления транспорта");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListBoxCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxCamp.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonCreateTransport_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedItem != null)
            {
                TypeOfTranpsortConfigForm typeOfTranpsortConfigForm = new TypeOfTranpsortConfigForm();
                typeOfTranpsortConfigForm.AddEvent(AddTransport);
                typeOfTranpsortConfigForm.Show();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    campCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неудачная попытка сохранить файл");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    campCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Warn("Попытка поставить транспорт на занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неудачная попытка загрузки файла");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
