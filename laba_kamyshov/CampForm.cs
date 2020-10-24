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

        private void parkTracked_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TrackedVehicle tracked = new TrackedVehicle(100, 1000, dialog.Color);
                    if (campCollection[listBoxCamp.SelectedItem.ToString()] + tracked)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Стоянка переполнена");
                    }
                }
            }
        }
        private void parkExcavator_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        Excavator ex = new Excavator(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        if (campCollection[listBoxCamp.SelectedItem.ToString()] + ex)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Стоянка переполнена");
                        }
                    }
                }
            }
        }
        private void takeExcavator_Click(object sender, EventArgs e)
        {
            if (listBoxCamp.SelectedIndex > -1 && MaskedBoxPlace.Text != "")
            {
                TrackedVehicle vehicle = campCollection[listBoxCamp.SelectedItem.ToString()] -
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

        private void listBoxCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
