using System.Drawing;

namespace laba_kamyshov
{
    internal class TrackedVehicle : Vehicle
    {
        protected readonly int Tracked_Vehicle_Width = 100;
        protected readonly int Tracked_Vehicle_Height = 100;
        protected double changeWidth = 2.5;
        protected double changeHeight = 1.7;
        public TrackedVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        protected TrackedVehicle(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Tracked_Vehicle_Width = carWidth;
            Tracked_Vehicle_Height = carHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (startPosX + step < pictureWidth - Tracked_Vehicle_Width * changeWidth)
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
                    if (startPosY + step < pictureHeight - Tracked_Vehicle_Height * changeHeight)
                    {
                        startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            Pen MainPen = new Pen(Color.Black, 5);
            //колеса гусеницы
            g.FillEllipse(new SolidBrush(Color.Black), startPosX + 45, startPosY + 105, Tracked_Vehicle_Width - 70, Tracked_Vehicle_Height - 70);
            g.FillEllipse(new SolidBrush(Color.Black), startPosX + 95, startPosY + 105, Tracked_Vehicle_Width - 70, Tracked_Vehicle_Height - 70);
            g.FillEllipse(new SolidBrush(Color.Black), startPosX + 145, startPosY + 105, Tracked_Vehicle_Width - 70, Tracked_Vehicle_Height - 70);
            //линии гусеницы
            PointF PtLine1_1 = new PointF(startPosX + 55, startPosY + 106);
            PointF PtLine1_2 = new PointF(startPosX + 165, startPosY + 106);
            PointF PtLine2_1 = new PointF(startPosX + 55, startPosY + 133);
            PointF PtLine2_2 = new PointF(startPosX + 165, startPosY + 133);
            g.DrawLine(pen, PtLine1_1, PtLine1_2);
            g.DrawLine(pen, PtLine2_1, PtLine2_2);
            g.DrawRectangle(pen, startPosX + 110, startPosY + 40, Tracked_Vehicle_Width - 65, Tracked_Vehicle_Height - 60);
            //корпус
            PointF[] Exc_pt = new PointF[6];
            Exc_pt[0] = new PointF(startPosX + 60, startPosY + 20);
            Exc_pt[1] = new PointF(startPosX + 160, startPosY + 20);
            Exc_pt[2] = new PointF(startPosX + 160, startPosY + 40);
            Exc_pt[3] = new PointF(startPosX + 160, startPosY + 100);
            Exc_pt[4] = new PointF(startPosX + 60, startPosY + 100);
            Exc_pt[5] = new PointF(startPosX + 60, startPosY + 20);
            g.FillRectangle(new SolidBrush(MainColor), startPosX + 40, startPosY + 60, Tracked_Vehicle_Width - 65, Tracked_Vehicle_Height - 60);
            g.DrawRectangle(pen, startPosX + 40, startPosY + 60, Tracked_Vehicle_Width - 65, Tracked_Vehicle_Height - 60);
            g.DrawPolygon(MainPen, Exc_pt);
            g.FillPolygon(new SolidBrush(MainColor), Exc_pt);
            //дверь
            g.FillRectangle(new SolidBrush(Color.Gray), startPosX + 110, startPosY + 40, Tracked_Vehicle_Width - 65, Tracked_Vehicle_Height - 60);
            g.FillRectangle(new SolidBrush(Color.Black), startPosX + 110, startPosY + 60, Tracked_Vehicle_Width - 65, Tracked_Vehicle_Height - 80);
        }
    }
}
