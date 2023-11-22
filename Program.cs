using System.Configuration;

namespace Fuel
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
            double valor = 0.00;
            double litros = 0.00;

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(valor, litros));
        }
    }
}