using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba_kamyshov
{
    class Excavator
    {

        private float startPosX;
        private float startPosY;
        private int pictureWidth;
        private int pictureHeight;
        private readonly int excavatorWidth = 100;
        private readonly int excavatorHeight = 100;
        private readonly double changeWidth = 2.7;
        private readonly double changeHeight = 1.5;


        public int MaxSpeed
        { private set; get; }

        public float Weight
        { private set; get; }

        public Color MainColor
        { private set; get; }

        public Color DopColor_Y
        { private set; get; }

        public Color DopColor_R
        { private set; get; }

        public Color DopColor_G
        { private set; get; }

        public bool Flasher
        { private set; get; }

        public bool Ladle
        { private set; get; }

        public bool Stand
        { private set; get; }

        public Excavator(int maxSpeed, float weight, Color mainColor, Color dopColor_y, Color dopColor_r, Color dopColor_g,
        bool flasher, bool ladle, bool stand)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor_Y = dopColor_y;
            DopColor_R = dopColor_r;
            DopColor_G = dopColor_g;
            Flasher = flasher;
            Ladle = ladle;
            Stand = stand;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            if (x >= 0 && x + excavatorWidth < width && y >= 0 && y + excavatorHeight < height)
            {
                startPosX = x;
                startPosY = y;
                pictureWidth = width;
                pictureHeight = height;
            }

        }
        public void MoveTrans(Direction dir)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (dir)
            {
                case Direction.Right:
                    if (startPosX + step < pictureWidth - excavatorWidth*changeWidth)
                    {
                        startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (startPosX - step > 0)
                    {
                        startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (startPosY - step > 0)
                    {
                        startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (startPosY + step < pictureHeight - excavatorHeight*changeHeight)
                    {
                        startPosY += step;
                    }
                    break;
            }
        }
        public void DrawPicture(Graphics g)
        {
            Pen pen = new Pen(MainColor, 3);
            Pen MainPen = new Pen(MainColor, 5);

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
                g.FillPolygon(new SolidBrush(DopColor_Y), Ladle_pt);
            }
            //подставка
            if (Stand)
            {
                Pen standing_pen_light = new Pen(MainColor, 5);
                Pen standing_pen_hard = new Pen(MainColor, 8);
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
                g.FillRectangle(new SolidBrush(DopColor_R), startPosX + 70, startPosY + 5, excavatorWidth - 92, excavatorHeight - 85);
                g.DrawRectangle(pen, startPosX + 70, startPosY + 5, excavatorWidth - 92, excavatorHeight - 85);
            }
            //колеса гусеницы
            g.FillEllipse(new SolidBrush(MainColor), startPosX + 45, startPosY + 105, excavatorWidth - 70, excavatorHeight - 70);
            g.FillEllipse(new SolidBrush(MainColor), startPosX + 95, startPosY + 105, excavatorWidth - 70, excavatorHeight - 70);
            g.FillEllipse(new SolidBrush(MainColor), startPosX + 145, startPosY + 105, excavatorWidth - 70, excavatorHeight - 70);
            //линии гусеницы
            PointF PtLine1_1 = new PointF(startPosX + 55, startPosY + 106);
            PointF PtLine1_2 = new PointF(startPosX + 165, startPosY + 106);
            PointF PtLine2_1 = new PointF(startPosX + 55, startPosY + 133);
            PointF PtLine2_2 = new PointF(startPosX + 165, startPosY + 133);
            g.DrawLine(pen, PtLine1_1, PtLine1_2);
            g.DrawLine(pen, PtLine2_1, PtLine2_2);
            g.DrawRectangle(pen, startPosX + 110, startPosY + 40, excavatorWidth - 65, excavatorHeight - 60);
            //корпус
            PointF[] Exc_pt = new PointF[6];
            Exc_pt[0] = new PointF(startPosX + 60, startPosY + 20);
            Exc_pt[1] = new PointF(startPosX + 160, startPosY + 20);
            Exc_pt[2] = new PointF(startPosX + 160, startPosY + 40);
            Exc_pt[3] = new PointF(startPosX + 160, startPosY + 100);
            Exc_pt[4] = new PointF(startPosX + 60, startPosY + 100);
            Exc_pt[5] = new PointF(startPosX + 60, startPosY + 20);
            g.FillRectangle(new SolidBrush(DopColor_Y), startPosX + 40, startPosY + 60, excavatorWidth - 65, excavatorHeight - 60);
            g.DrawRectangle(pen, startPosX + 40, startPosY + 60, excavatorWidth - 65, excavatorHeight - 60);
            g.DrawPolygon(MainPen, Exc_pt);
            g.FillPolygon(new SolidBrush(DopColor_Y), Exc_pt);
            //дверь
            g.FillRectangle(new SolidBrush(DopColor_G), startPosX + 110, startPosY + 40, excavatorWidth - 65, excavatorHeight - 60);
            g.FillRectangle(new SolidBrush(MainColor), startPosX + 110, startPosY + 60, excavatorWidth - 65, excavatorHeight - 80);
        
     
            
        }
    }
}
