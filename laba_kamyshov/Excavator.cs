using System;
using System.Drawing;

namespace laba_kamyshov
{
    internal class Excavator : TrackedVehicle
    {
        public Color DopColor
        { protected set; get; }
        public bool Flasher
        { private set; get; }
        public bool Ladle
        { private set; get; }
        public bool Stand
        { private set; get; }

        public Excavator(int maxSpeed, float weight, Color mainColor, Color dopColor,
         bool flasher, bool ladle, bool stand) : base(maxSpeed, weight, mainColor, 100, 100)
        {
            DopColor = dopColor;
            Flasher = flasher;
            Ladle = ladle;
            Stand = stand;
        }

        public Excavator(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Flasher = Convert.ToBoolean(strs[4]);
                Ladle = Convert.ToBoolean(strs[5]);
                Stand = Convert.ToBoolean(strs[6]);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            Pen MainPen = new Pen(Color.Black, 5);

            //ковш
            if (Ladle)
            {
                PointF[] Ladle_pt = new PointF[10];
                Ladle_pt[0] = new PointF(startPosX + 160, startPosY + 40);
                Ladle_pt[1] = new PointF(startPosX + 200, startPosY);
                Ladle_pt[2] = new PointF(startPosX + 260, startPosY + 60);
                Ladle_pt[3] = new PointF(startPosX + 250, startPosY + 80);
                Ladle_pt[4] = new PointF(startPosX + 230, startPosY + 60);
                Ladle_pt[5] = new PointF(startPosX + 220, startPosY + 80);
                Ladle_pt[6] = new PointF(startPosX + 200, startPosY + 60);
                Ladle_pt[7] = new PointF(startPosX + 220, startPosY + 40);
                Ladle_pt[8] = new PointF(startPosX + 200, startPosY + 20);
                Ladle_pt[9] = new PointF(startPosX + 160, startPosY + 60);
                g.DrawPolygon(MainPen, Ladle_pt);
                g.FillPolygon(new SolidBrush(DopColor), Ladle_pt);
            }
            //подставка
            if (Stand)
            {
                Pen standing_pen_light = new Pen(Color.Black, 5);
                Pen standing_pen_hard = new Pen(Color.Black, 8);
                PointF Pt_Stand_1 = new PointF(startPosX + 50, startPosY + 70);
                PointF Pt_Stand_2 = new PointF(startPosX + 20, startPosY + 130);
                PointF Pt_Stand_3 = new PointF(startPosX, startPosY + 130);
                PointF Pt_Stand_4 = new PointF(startPosX + 40, startPosY + 130);
                g.DrawLine(standing_pen_light, Pt_Stand_1, Pt_Stand_2);
                g.DrawLine(standing_pen_hard, Pt_Stand_3, Pt_Stand_4);
            }
            //фонарик
            if (Flasher)
            {
                g.FillRectangle(new SolidBrush(Color.Red), startPosX + 70, startPosY + 5, Tracked_Vehicle_Width - 92, Tracked_Vehicle_Height - 85);
                g.DrawRectangle(pen, startPosX + 70, startPosY + 5, Tracked_Vehicle_Width - 92, Tracked_Vehicle_Height - 85);
            }
            base.DrawTransport(g);
        }

        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Flasher}{separator}{Ladle}{separator}{Stand}";
        }
    }
}
