using Main;
using SistemaBancario.Views;
using System;
using SistemaBancario.Log;
using System.Windows.Forms;

namespace SistemaBancario
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.logger.Information("Iniciando o programa.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
    }
}
