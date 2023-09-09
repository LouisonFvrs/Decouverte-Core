using TP1_SLAM5.Entities;

namespace TP1_SLAM5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Modele.init();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}