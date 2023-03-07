using System;
using System.Windows.Forms;
using Serilog;
using Serilog.Formatting.Json;

namespace CadastroTrilhar
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("Log/CadastroTrilhar_.log", rollingInterval: RollingInterval.Day)
                //.Destructure.With<Serilog.Expressions>()
                .CreateLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Trilhar.Forms.FormPrincipal());
            
            Log.CloseAndFlush();
        }
    }
}
