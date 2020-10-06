using System.Drawing;

namespace laba_kamyshov
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Direction direction);

        void DrawTransport(Graphics g);
    }
}
