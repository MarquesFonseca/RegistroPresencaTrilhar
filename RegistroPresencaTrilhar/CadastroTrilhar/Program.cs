using log4net;
using System;
using System.Windows.Forms;

namespace CadastroTrilhar
{
    static class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            logger.Info("Clicou em Fechar... O sistema está sendo encerrado....");

            Application.Run(new Trilhar.Forms.Principal());
        }
    }
}
