using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba_kamyshov
{
    public partial class TypeOfTranpsortConfigForm : Form
    {
        private Vehicle transport = null;

        public TypeOfTranpsortConfigForm()
        {
            InitializeComponent();
            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;
            panelColorRed.MouseDown += panelColor_MouseDown;
            panelColorOrange.MouseDown += panelColor_MouseDown;
            panelColorYellow.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorGreen.MouseDown += panelColor_MouseDown;
            panelColorGray.MouseDown += panelColor_MouseDown;
            ButtonCancelChoose.Click += (object sender, EventArgs e) => { Close(); };
        }

        private event VehicleDelegate eventAddTransport;

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        public void AddEvent(VehicleDelegate ev)
        {
            if (eventAddTransport == null)
            {
                eventAddTransport = new VehicleDelegate(ev);
            }
            else
            {
                eventAddTransport += ev;
            }
        }

        private void Draw()
        {
            if (transport != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTransport.Width, pictureBoxTransport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                transport.SetPosition(5, 5, pictureBoxTransport.Width, pictureBoxTransport.Height);
                transport.DrawTransport(gr);
                pictureBoxTransport.Image = bmp;
            }
        }

        private void TrackedVehicleLable_MouseDown(object sender, MouseEventArgs e)
        {
            TrackedVehicleLable.DoDragDrop(TrackedVehicleLable.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void ExcavatorLable_MouseDown(object sender, MouseEventArgs e)
        {
            ExcavatorLable.DoDragDrop(ExcavatorLable.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTransport_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Гусеничная машина":
                    transport = new TrackedVehicle((int)ChooseMaxSpeed.Value, (int)ChooseWeight.Value, Color.White);
                    break;
                case "Экскаватор":
                    transport = new Excavator((int)ChooseMaxSpeed.Value, (int)ChooseWeight.Value, Color.White, Color.White,
                        CheckBoxAttachFlasher.Checked, CheckBoxAttachLadle.Checked, CheckBoxAttachStand.Checked);
                    break;
            }
            Draw();
        }

        private void panelTransport_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainColorLable_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainColorLable_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                transport.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void AdditionalColorLable_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                if (transport is Excavator)
                {
                    (transport as Excavator).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void ButtonAddTransport_Click(object sender, EventArgs e)
        {
            eventAddTransport?.Invoke(transport);
            Close();
        }
    }
}
