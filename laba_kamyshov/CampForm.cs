using System;
using System.Drawing;
using System.Windows.Forms;


namespace laba_kamyshov
{
    public partial class CampForm : Form
    {
        private readonly Camp<TrackedVehicle> camp;
        public CampForm()
        {
            InitializeComponent();
            camp = new Camp<TrackedVehicle>(pictureCampBox.Width,
            pictureCampBox.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureCampBox.Width, pictureCampBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            camp.Draw(gr);
            pictureCampBox.Image = bmp;
        }
        private void parkTracked_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TrackedVehicle tracked = new TrackedVehicle(100, 1000, dialog.Color);

                if (camp + tracked)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        private void parkExcavator_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {

                    Excavator ex = new Excavator(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    if (camp + ex)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }

                }
            }
        }
        private void takeExcavator_Click(object sender, EventArgs e)
        {
            if (placeCount.Text != "")
            {
                TrackedVehicle vehicle = camp - Convert.ToInt32(placeCount.Text);
                if (vehicle != null)
                {
                    ExcavatorForm form = new ExcavatorForm();
                    form.SetCar(vehicle);
                    Draw();
                    form.ShowDialog();
                }
            }
        }
    }
}
