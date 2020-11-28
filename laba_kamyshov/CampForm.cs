using System;
using System.Drawing;
using System.Windows.Forms;


namespace laba_kamyshov
{
    public partial class CampForm : Form
    {
        private readonly CampCollection campCollection;

        public CampForm()
        {
            InitializeComponent();
            campCollection = new CampCollection(pictureCampBox.Width, pictureCampBox.Height);
            Draw();
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
                Vehicle vehicle = campCollection[listBoxCamp.SelectedItem.ToString()] -
                Convert.ToInt32(MaskedBoxPlace.Text);
                if (vehicle != null)
                {
                    ExcavatorForm form = new ExcavatorForm();
                    form.SetCar(vehicle);
                    Draw();
                    form.ShowDialog();
                }
            }
        }

        private void AddTransport(Vehicle transport)
        {
            if (transport != null && listBoxCamp.SelectedIndex > -1)
            {
                if ((campCollection[listBoxCamp.SelectedItem.ToString()]) + transport)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не удалось поставить транспорт");
                }
            }
        }

        private void ListBoxCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonCreateTransport_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedItem != null)
            {
                var typeOfTranpsortConfigForm = new TypeOfTranpsortConfigForm();
                typeOfTranpsortConfigForm.AddEvent(AddTransport);
                typeOfTranpsortConfigForm.Show();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (campCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сохранение не выполнено", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (campCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Загрузка не выполнена", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}
