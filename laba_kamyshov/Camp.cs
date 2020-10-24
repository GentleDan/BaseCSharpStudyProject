using System.Collections.Generic;
using System.Drawing;

namespace laba_kamyshov
{
    public class Camp<T> where T : class, ITransport
    {
        private readonly List<T> places;

        private readonly int maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int placeSizeWidth = 280;

        private readonly int placeSizeHeight = 160;

        public Camp(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            maxCount = width * height;
            places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Camp<T> camp, T vehicle)
        {
            if (camp.places.Count >= camp.maxCount)
            {
                return false;
            }
            camp.places.Add(vehicle);
            return true;
        }

        public static T operator -(Camp<T> camp, int index)
        {
            if (index < -1 || index > camp.places.Count)
            {
                return null;
            }
            T vehicle = camp.places[index];
            camp.places.RemoveAt(index);
            return vehicle;
        }

        public void Draw(Graphics g)
        {
            int changeHeight = 10;
            int width = pictureWidth / placeSizeWidth;
            DrawMarking(g);
            for (int i = 0; i < places.Count; i++)
            {
                places[i].SetPosition(i / width * placeSizeWidth + changeHeight,
                    i % width * placeSizeHeight + changeHeight, pictureWidth,
                    pictureHeight);
                places[i].DrawTransport(g);
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

