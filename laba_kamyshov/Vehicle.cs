using System.Drawing;

namespace laba_kamyshov
{
    public abstract class Vehicle : ITransport
    {
        protected float startPosX;

        protected float startPosY;

        protected int pictureWidth;

        protected int pictureHeight;

        protected int vehicleWight = 100;

        protected int vehicleHeight = 100;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            if (x >= 0 && x + vehicleWight < width && y >= 0 && y + vehicleHeight < height)
            {
                startPosX = x;
                startPosY = y;
                pictureWidth = width;
                pictureHeight = height;
            }
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
