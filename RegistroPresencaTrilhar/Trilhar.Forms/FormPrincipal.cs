using Serilog;
using System;
using System.Windows.Forms;

namespace Trilhar.Forms
{
    public partial class FormPrincipal : Form
    {
        private static readonly ILogger logger = Log.Logger;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void menuCadastro_CadastroCriancaTrilhar_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item.Name == "Principal")
                {
                    item.Close();
                    break;
                }
            }

            FormCadastroCriancaTrilhar formPrincipal = new FormCadastroCriancaTrilhar();
            formPrincipal.MdiParent = this;
            formPrincipal.Show();
            //formularioSRORastreamentoUnificado.WindowState = FormWindowState.Normal;
            formPrincipal.WindowState = FormWindowState.Maximized;
            formPrincipal.Activate();
        }

        private void botao_CadastroCriancaTrilhar_Click(object sender, EventArgs e)
        {
            menuCadastro_CadastroCriancaTrilhar_Click(sender, e);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar a aplicação?", "Fechar Aplicação", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                logger.Information("Fechando o principal.");
            }
        }
    }
}
