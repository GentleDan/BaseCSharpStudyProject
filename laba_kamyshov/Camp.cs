using System.Drawing;

namespace laba_kamyshov
{
    internal class Camp<T> where T : class, ITransport
    {
        private readonly T[] places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int placeSizeWidth = 280;

        private readonly int placeSizeHeight = 160;

        public Camp(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Camp<T> camp, T vehicle)
        {
            int changeHeight = 10;
            int width = camp.pictureWidth / camp.placeSizeWidth;

            for (int i = 0; i < camp.places.Length; i++)
            {
                if (camp.CheckFreePlace(i))
                {
                    camp.places[i] = vehicle;
                    camp.places[i].SetPosition(i / width * camp.placeSizeWidth + changeHeight,
                    i % width * camp.placeSizeHeight + changeHeight, camp.pictureWidth,
                    camp.pictureHeight);
                    return true;
                }
            }
            return false;
        }
        public static T operator -(Camp<T> camp, int index)
        {
            if (index < 0 || index > camp.places.Length)
            {
                return null;
            }
            if (!camp.CheckFreePlace(index))
            {
                T vehicle = camp.places[index];
                camp.places[index] = null;
                return vehicle;
            }
            return null;
        }

        private bool CheckFreePlace(int indexPlace)
        {
            return places[indexPlace] == null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            double changeLong = 1.2;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, (float)(i *
                   placeSizeWidth + placeSizeWidth / changeLong), j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth,
               (pictureHeight / placeSizeHeight) * placeSizeHeight);
            }
        }
    }
}

