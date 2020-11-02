using System;
using System.Windows.Forms;

namespace laba_kamyshov
{
    public delegate void VehicleDelegate(Vehicle transport);

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CampForm());
        }
    }
}
