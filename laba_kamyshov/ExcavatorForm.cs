using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_kamyshov
{
	public partial class ExcavatorForm : Form
	{
		private Excavator ex;
		public ExcavatorForm()
		{
			InitializeComponent();
		}

		private void Create_button_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			ex = new Excavator(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black,
		   Color.Yellow, Color.Red, Color.Gray, true, true, true);
			ex.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxEx.Width,
		   pictureBoxEx.Height);
			Draw();
		}


		public void Draw()
		{
			{
				Bitmap bmp = new Bitmap(pictureBoxEx.Width, pictureBoxEx.Height);
				Graphics gr = Graphics.FromImage(bmp);
				ex.DrawPicture(gr);
				pictureBoxEx.Image = bmp;

			}

		}
		public void MoveExcavator(object sender, EventArgs e)
		{
			if (ex != null)
			{
				string name = (sender as Button).Name;
				switch (name)
				{
					case "button_Up":
						ex.MoveTrans(Direction.Up);
						break;
					case "button_Down":
						ex.MoveTrans(Direction.Down);
						break;
					case "button_Left":
						ex.MoveTrans(Direction.Left);
						break;
					case "button_Right":
						ex.MoveTrans(Direction.Right);
						break;
				}
				Draw();
			}
		}

	}
}
