using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba_kamyshov
{
    public partial class ExcavatorForm : Form
    {
        private ITransport ex;
        public ExcavatorForm()
        {
            InitializeComponent();
        }

        public void SetCar(ITransport excavator)
        {
            ex = excavator;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxEx.Width, pictureBoxEx.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ex?.DrawTransport(gr);
            pictureBoxEx.Image = bmp;
        }

        private void CreateTrackedVehicle_button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ex = new TrackedVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow);
            ex.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxEx.Width, pictureBoxEx.Height);
            Draw();
        }

        private void CreateExcavator_button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ex = new Excavator(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow, Color.Yellow, true, true, true);
            ex.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxEx.Width, pictureBoxEx.Height);
            Draw();
        }

        private void button_Move_Click(object sender, EventArgs e)
        {
            if (ex != null)
            {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "button_Up":
                        ex?.MoveTransport(Direction.Up);
                        break;
                    case "button_Down":
                        ex?.MoveTransport(Direction.Down);
                        break;
                    case "button_Left":
                        ex?.MoveTransport(Direction.Left);
                        break;
                    case "button_Right":
                        ex?.MoveTransport(Direction.Right);
                        break;
                }
                Draw();
            }
        }
    }
}
