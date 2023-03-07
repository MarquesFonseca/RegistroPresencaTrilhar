using Mapster;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Trilhar.Entidades;
using Trilhar.Uteis;
using Trilhar.Controle;
using System.Reflection;

namespace Trilhar.Forms
{
    public partial class FormCadastroCriancaTrilhar : Form
    {
        private static readonly ILogger logger = Log.Logger;

        List<Record> recordsList = new List<Record>();
        List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();
        ValuesDTO valuesDTOAtual = new ValuesDTO();

        public EstadoFormularioCadastro estadoFormularioCadastro;

        public FormCadastroCriancaTrilhar()
        {
            InitializeComponent();

#if (DEBUG)
            TxtId.Visible = true;
#endif
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Log.Error(ex, "Ocorreu um erro durante a execução do aplicativo: {Contexto}", new { Usuario = "João", IP = "192.168.1.1" });            
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            AlterarEstadoFormulario(EstadoFormularioCadastro.Inicio);
            
            //AtualizaDados();           
        }

        private void AlterarEstadoFormulario(EstadoFormularioCadastro EstadoAtual)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            logger.Information("\t\tParametro entrada: {@Valor1}", new { EstadoAtual });
            this.estadoFormularioCadastro = EstadoAtual;
            switch (EstadoAtual)
            {
                #region Acao.Inicio
                case EstadoFormularioCadastro.Inicio:
                    // TODO: Acao.Inicio:
                    TxtTurmaAtual.Visible = TxtDataNascimento.Visible = true;
                    CmbTurmaAtual.Visible = false;

                    LimparCampos();
                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(false);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);

                    TxtDataNascimento.Text = "";

                    linkLabelAtualizarDados.Enabled = true;

                    BtnNovo.Enabled = true;

                    numericUpDown1.Enabled = false;
                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);

                    break;
                #endregion
                #region Acao.Novo
                case EstadoFormularioCadastro.Novo:
                    // TODO: Acao.Novo:
                    TxtTurmaAtual.Visible = false;
                    CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = true;

                    TxtCmbBatizado.SelectedItem = "NÃO";
                    TxtCmbAlergia.SelectedItem = "NÃO";
                    TxtCmbRestrincaoAlimentar.SelectedItem = "NÃO";
                    TxtCmbDeficienteAtipicos.SelectedItem = "NÃO";

                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(false);
                    HabilitaDesabilitaBotoes(false);
                    LimparCampos();

                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;

                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;

                    TxtTurmaAtual.BackColor = SystemColors.Window;
                    TxtTurmaAtual.ForeColor = SystemColors.WindowText;

                    numericUpDown1.Enabled = false;
                    TxtNomeCrianca.Focus();
                    TxtNomeCrianca.SelectAll();
                    break;
                #endregion
                #region Acao.NovoAproveitando
                case EstadoFormularioCadastro.NovoAproveitando:
                    // TODO: Acao.NovoAproveitando:
                    TxtTurmaAtual.Visible = false;
                    //CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = true;

                    //TxtCmbAlergia.SelectedItem = "NÃO";
                    //TxtCmbRestrincaoAlimentar.SelectedItem = "NÃO";
                    //TxtCmbDeficienteAtipicos.SelectedItem = "NÃO";

                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(false);
                    HabilitaDesabilitaBotoes(false);
                    //LimparCampos();
                    TxtNomeCrianca.Text = "";
                    TxtDataNascimento.Text = "";
                    TxtIdadeCrianca.Text = "";
                    TxtTurmaAtual.Text = "";
                    CmbTurmaAtual.SelectedIndex = -1;

                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;

                    numericUpDown1.Enabled = false;
                    TxtNomeCrianca.Focus();
                    TxtNomeCrianca.SelectAll();
                    break;
                #endregion
                #region Acao.Alterar
                case EstadoFormularioCadastro.Alterar:
                    // TODO: Acao.Alterar:
                    TxtTurmaAtual.Visible = false;
                    CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = true;

                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(false);
                    HabilitaDesabilitaBotoes(false);

                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;

                    CarregaCampos(valuesDTOAtual);

                    numericUpDown1.Enabled = false;
                    TxtNomeCrianca.Focus();
                    //TxtNomeCrianca.SelectAll();
                    break;
                #endregion
                #region Acao.Excluir
                case EstadoFormularioCadastro.Excluir:
                    // TODO: Acao.Excluir:
                    break;
                #endregion
                #region Acao.Cancelar
                case EstadoFormularioCadastro.Cancelar:
                    // TODO: Acao.Cancelar:
                    TxtTurmaAtual.Visible = TxtDataNascimento.Visible = true;
                    CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = false;

                    HabilitaDesabilitaLinkButon(true);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);

                    BtnNovo.Enabled = true;
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;

                    CarregaCampos(valuesDTOAtual);

                    AlterarEstadoFormulario(EstadoFormularioCadastro.Preenchido);
                    break;
                #endregion
                #region Acao.Sincronizando
                case EstadoFormularioCadastro.Sincronizando:
                    // TODO: Acao.Sincronizando:
                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(false);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);
                    LimparCampos();
                    TxtDataNascimento.Text = "";
                    TxtTurmaAtual.BackColor = SystemColors.Window;
                    TxtTurmaAtual.ForeColor = SystemColors.WindowText;
                    break;
                #endregion
                #region Acao.Preenchido
                case EstadoFormularioCadastro.Preenchido:
                    // TODO: Acao.Preenchido:
                    TxtTurmaAtual.Visible = TxtDataNascimento.Visible = true;
                    CmbTurmaAtual.Visible = false;

                    HabilitaDesabilitaLinkButon(true);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);

                    //TxtDataNascimento.Enabled = false;
                    //TxtCmbAlergia.Enabled = false;
                    //TxtCmbRestrincaoAlimentar.Enabled = false;
                    //TxtCmbDeficienteAtipicos.Enabled = false;

                    BtnNovo.Enabled = true;
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;

                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    break;
                #endregion
                default:
                    break;
            }
        }

        private void HabilitaDesabilitaBotoes(bool valor)
        {
            //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", new { valor });

            BtnNovo.Enabled = valor;
            BtnAlterar.Enabled = valor;
            BtnExcluir.Enabled = valor;
            BtnCancelar.Enabled = valor;
            BtnSalvar.Enabled = valor;
        }

        private void CarregaCampos(ValuesDTO itemAtual)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            logger.Information("\t\tParametro entrada: {@Valor1}", new { itemAtual });

            //TODO: CarregaCampos()
            valuesDTOAtual = itemAtual;            

            #region CodigoCadastro
            numericUpDown1.Value = itemAtual != null && itemAtual.CodigoCadastro != null
                    ? Convert.ToDecimal(itemAtual.CodigoCadastro)
                    : 0000;

            #endregion

            #region id
            var record = recordsList.Where(M => M.values.Adapt<Values, ValuesDTO>().CodigoCadastro == itemAtual.CodigoCadastro).FirstOrDefault();
            TxtId.Text = record.id;
            #endregion

            #region NomeCrianca
            TxtNomeCrianca.Text = itemAtual != null && itemAtual.NomeCrianca != null ? itemAtual.NomeCrianca : "";
            TxtNomeCrianca.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomeCrianca.Text);
            #endregion

            #region SelecioneATurma
            if (itemAtual != null && itemAtual.SelecioneATurma != null)
            {
                TxtTurmaAtual.Text = itemAtual.SelecioneATurma;
                CmbTurmaAtual.SelectedItem = itemAtual.SelecioneATurma;

                if (TxtTurmaAtual.Text.ToUpper().Contains("LILÁS (1 ano)".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(200, 162, 200);
                    TxtTurmaAtual.ForeColor = SystemColors.ControlText;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("LILÁS (2 ANOS)".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(153, 50, 204);
                    TxtTurmaAtual.ForeColor = SystemColors.Info;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("LARANJA".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(255, 165, 0);
                    TxtTurmaAtual.ForeColor = SystemColors.Info;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("VERMELHO".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(255, 0, 0);
                    TxtTurmaAtual.ForeColor = SystemColors.Info;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("VERDE".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(0, 255, 100);
                    TxtTurmaAtual.ForeColor = SystemColors.ControlText;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("AZUL".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(173, 216, 230);
                    TxtTurmaAtual.ForeColor = SystemColors.ControlText;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("AZUL ROYAL".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(0, 0, 128);
                    TxtTurmaAtual.ForeColor = SystemColors.Info;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("ROSA".ToUpper()))
                {
                    TxtTurmaAtual.BackColor = Color.FromArgb(255, 192, 203);
                    TxtTurmaAtual.ForeColor = SystemColors.ControlText;
                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                }
            }
            else
            {
                TxtTurmaAtual.Text = "";
                CmbTurmaAtual.SelectedIndex = -1;
                TxtTurmaAtual.BackColor = Color.Empty;
                TxtTurmaAtual.ForeColor = SystemColors.InfoText;
                CmbTurmaAtual.ForeColor = SystemColors.ControlText;
            }
            #endregion

            #region DataNascimento + IdadeCrianca
            if (itemAtual != null && itemAtual.DataNascimento != null)
            {
                if (itemAtual.DataNascimento.VerificaSeDataValida() == false)
                {
                    MessageBox.Show(string.Format("Ocorreu um erro no cadastro de número '{0}'.\nA data informada '{1}' não está no padrão correto.\nÉ necessário que haja uma correção para esse cadastro atravez da plataforma web.\nApós corrigir, volte a tentar!", itemAtual.CodigoCadastro, itemAtual.DataNascimento), "Informativo");
                    AlterarEstadoFormulario(EstadoFormularioCadastro.Inicio);
                    return;
                }
            }

            TxtDataNascimento.Text = itemAtual != null && itemAtual.DataNascimento != null ? itemAtual.DataNascimento : "";
            TxtIdadeCrianca.Text = DataUteis.PreencheIdadeFormatada(TxtDataNascimento.Text);
            #endregion

            #region Mae
            TxtMae.Text = itemAtual != null && itemAtual.Mae != null ? itemAtual.Mae : "";
            TxtMae.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtMae.Text.ToLower());
            #endregion

            #region Pai
            TxtPai.Text = itemAtual != null && itemAtual.Pai != null ? itemAtual.Pai : "";
            TxtPai.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtPai.Text.ToLower());
            #endregion

            #region Outro Responsável
            TxtOutroResponsavel.Text = itemAtual != null && itemAtual.OutroResponsavel != null ? itemAtual.OutroResponsavel : "";
            if (itemAtual != null && itemAtual.OutroResponsavel != null)
            {
                if (itemAtual.OutroResponsavel == "Outro responsável: Tio, Tia, Avós ou Amigos")
                {
                    TxtOutroResponsavel.Text = "";
                }
                else
                {
                    TxtOutroResponsavel.Text = itemAtual.OutroResponsavel;
                }
            }
            else
            {
                TxtOutroResponsavel.Text = "";
            }
            #endregion

            #region Telefone
            TxtTelefone.Text = itemAtual != null && itemAtual.Telefone != null ? itemAtual.Telefone : "";
            #endregion

            #region Email
            TxtEmail.Text = itemAtual != null && itemAtual.EnderecoEmail != null ? itemAtual.EnderecoEmail.ToLower() : "";
            #endregion

            #region Batizado
            TxtCmbBatizado.Text = itemAtual != null && itemAtual.Batizado != null ? itemAtual.Batizado : "";
            if (TxtCmbBatizado.Text.ToUpper() == "SIM")
            {
                TxtCmbBatizado.SelectedItem = "SIM";
            }
            else
            {
                TxtCmbBatizado.SelectedItem = "NÃO";
            }
            #endregion

            #region Data Batismo
            TxtDataBatismo.Text = itemAtual != null && itemAtual.DataBatismo != null ? itemAtual.DataBatismo : "";
            #endregion

            #region Igreja Batismo
            TxtIgrejaBatismo.Text = itemAtual != null && itemAtual.IgrejaBatizou != null ? itemAtual.IgrejaBatizou : "";
            #endregion

            #region Alergia + Descricao
            TxtCmbAlergia.Text = itemAtual != null && itemAtual.Alergia != null ? itemAtual.Alergia : "";
            if (TxtCmbAlergia.Text.ToUpper() == "SIM")
            {
                TxtCmbAlergia.SelectedItem = "SIM";
                LblAlergia.BackColor = System.Drawing.Color.Red;
                LblAlergia.ForeColor = System.Drawing.SystemColors.Info;
                TxtDescicaoAlergia.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                TxtCmbAlergia.SelectedItem = "NÃO";
                LblAlergia.BackColor = System.Drawing.SystemColors.Control;
                LblAlergia.ForeColor = System.Drawing.SystemColors.ControlText;
                TxtDescicaoAlergia.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            TxtDescicaoAlergia.Text = itemAtual != null && itemAtual.SeAlergiaSimPreenchaAqui != null ? itemAtual.SeAlergiaSimPreenchaAqui : "";
            #endregion

            #region RestrincaoAlimentar + Descricao
            TxtCmbRestrincaoAlimentar.Text = itemAtual != null && itemAtual.RestrincaoAlimentar != null ? itemAtual.RestrincaoAlimentar : "";
            if (TxtCmbRestrincaoAlimentar.Text.ToUpper() == "SIM")
            {
                TxtCmbRestrincaoAlimentar.SelectedItem = "SIM";
                LblRestrincaoAlimentar.BackColor = System.Drawing.Color.Red;
                LblRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.Info;
                TxtDescricaoRestricaoAlimentar.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                TxtCmbRestrincaoAlimentar.SelectedItem = "NÃO";
                LblRestrincaoAlimentar.BackColor = System.Drawing.SystemColors.Control;
                LblRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.ControlText;
                TxtDescricaoRestricaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            TxtDescricaoRestricaoAlimentar.Text = itemAtual != null && itemAtual.SeRestrincaoAlimentarSimDescreva != null ? itemAtual.SeRestrincaoAlimentarSimDescreva : "";
            #endregion

            #region Deficiencia + Descricao
            TxtCmbDeficienteAtipicos.Text = itemAtual != null && itemAtual.AlgumaDeficienciaOuSituacaoAtipica != null ? itemAtual.AlgumaDeficienciaOuSituacaoAtipica : "";
            if (TxtCmbDeficienteAtipicos.Text.ToUpper() == "SIM")
            {
                TxtCmbDeficienteAtipicos.SelectedItem = "SIM";
                LblDeficiente.BackColor = System.Drawing.Color.Red;
                LblDeficiente.ForeColor = System.Drawing.SystemColors.Info;
                TxtDescricaoDeficienteAtipicos.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                TxtCmbDeficienteAtipicos.SelectedItem = "NÃO";
                LblDeficiente.BackColor = System.Drawing.SystemColors.Control;
                LblDeficiente.ForeColor = System.Drawing.SystemColors.ControlText;
                TxtDescricaoDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.WindowText;
            }

            TxtDescricaoDeficienteAtipicos.Text = itemAtual != null && itemAtual.SeAlgumaDeficienciaDescrevaOsDetalhes != null ? itemAtual.SeAlgumaDeficienciaDescrevaOsDetalhes : "";
            #endregion
        }

        public void HabilitaDesabilitaCampos(bool valor)
        {
            //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", new { valor });

            numericUpDown1.Enabled = valor;
            TxtNomeCrianca.Enabled = valor;
            TxtTurmaAtual.Enabled = valor;
            CmbTurmaAtual.Enabled = valor;
            TxtDataNascimento.Enabled = valor;
            TxtIdadeCrianca.Enabled = valor;
            TxtMae.Enabled = valor;
            TxtPai.Enabled = valor;
            TxtOutroResponsavel.Enabled = valor;
            TxtTelefone.Enabled = valor;
            TxtEmail.Enabled = valor;
            TxtCmbBatizado.Enabled = valor;
            TxtDataBatismo.Enabled = valor;
            TxtIgrejaBatismo.Enabled = valor;
            TxtCmbAlergia.Enabled = valor;
            TxtDescicaoAlergia.Enabled = valor;
            TxtCmbRestrincaoAlimentar.Enabled = valor;
            TxtDescricaoRestricaoAlimentar.Enabled = valor;
            TxtCmbDeficienteAtipicos.Enabled = valor;
            TxtDescricaoDeficienteAtipicos.Enabled = valor;
        }

        public void HabilitaDesabilitaLinkButon(bool valor)
        {
            //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", new { valor });

            linkLabelBuscarPeloNome.Enabled = valor;
            linkLabelBuscarPelaMae.Enabled = valor;
            linkLabelBuscarPeloPai.Enabled = valor;
            linkLabelBuscarPelaTurma.Enabled = valor;
            linkLabelAtualizarDados.Enabled = valor;
        }

        public void ReadOnlyCampos(bool valor)
        {
            //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", new { valor });

            TxtNomeCrianca.ReadOnly = valor;
            TxtTurmaAtual.ReadOnly = valor;
            TxtDataNascimento.ReadOnly = valor;
            // TxtIdadeCrianca.ReadOnly = valor;
            TxtMae.ReadOnly = valor;
            TxtPai.ReadOnly = valor;
            TxtOutroResponsavel.ReadOnly = valor;
            TxtTelefone.ReadOnly = valor;
            TxtEmail.ReadOnly = valor;
            TxtDataBatismo.ReadOnly = valor;
            TxtIgrejaBatismo.ReadOnly = valor;
            TxtCmbBatizado.Enabled = !valor;
            TxtCmbAlergia.Enabled = !valor;
            TxtDescicaoAlergia.ReadOnly = valor;
            TxtCmbRestrincaoAlimentar.Enabled = !valor;
            TxtDescricaoRestricaoAlimentar.ReadOnly = valor;
            TxtCmbDeficienteAtipicos.Enabled = !valor;
            TxtDescricaoDeficienteAtipicos.ReadOnly = valor;
        }

        public void LimparCampos()
        {
            //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            numericUpDown1.Value = 0;
            TxtNomeCrianca.ResetText();
            TxtTurmaAtual.ResetText();
            TxtDataNascimento.ResetText();
            TxtIdadeCrianca.ResetText();
            TxtMae.ResetText();
            TxtPai.ResetText();
            TxtOutroResponsavel.ResetText();
            TxtTelefone.ResetText();
            TxtEmail.ResetText();
            TxtDataBatismo.ResetText();
            TxtIgrejaBatismo.ResetText();
            TxtCmbBatizado.ResetText();
            TxtCmbBatizado.SelectedItem = "NÃO";
            TxtCmbAlergia.ResetText();
            TxtCmbAlergia.SelectedItem = "NÃO";
            TxtDescicaoAlergia.ResetText();
            TxtCmbRestrincaoAlimentar.ResetText();
            TxtCmbRestrincaoAlimentar.SelectedItem = "NÃO";
            TxtDescricaoRestricaoAlimentar.ResetText();
            TxtCmbDeficienteAtipicos.ResetText();
            TxtCmbDeficienteAtipicos.SelectedItem = "NÃO";
            TxtDescricaoDeficienteAtipicos.ResetText();
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
                //logger.Information("\t\tParametro entrada: {@Valor1}", "Keys.Enter");

                e.Handled = true;
                e.SuppressKeyPress = true;
                numericUpDown1.Enabled = false;

                string valorAtualTextBox = numericUpDown1.Text;
                var itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == numericUpDown1.Text).FirstOrDefault();
                CarregaCampos(itemAtual);
                AlterarEstadoFormulario(EstadoFormularioCadastro.Preenchido);
                if (itemAtual == null)
                    numericUpDown1.Text = valorAtualTextBox;
                if (itemAtual != null)
                    numericUpDown1.Value = Convert.ToDecimal(itemAtual.CodigoCadastro);

                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                //logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
                //logger.Information("\t\tParametro entrada: {@Valor1}", e.KeyCode);

                e.Handled = true;
                e.SuppressKeyPress = true;

                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
            }
        }

        private void linkLabelAtualizarDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            AlterarEstadoFormulario(EstadoFormularioCadastro.Sincronizando);

            AtualizaDados();
        }

        public async void AtualizaDados()
        {
            try
            {
                logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
                //logger.Information("\t\tParametro entrada: {@Valor1}", new { });

                //TODO: AtualizaDados()
                recordsList = await new IntegracaoQuintaDBTrilharControle().RetornarListaAsync();
                valuesDTOList = CadastroTrilharAuxiliaresControle.GetListValues(recordsList);

                if (valuesDTOList == null || valuesDTOList.Count == 0)
                {
                    //HabilitaDesabilitaCampos(false);
                    linkLabelAtualizarDados.Enabled = true;
                    BtnNovo.Enabled = true;
                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;

                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                }
                else
                {
                    ValuesDTO lastRecord = valuesDTOList.OrderBy(r => r.CodigoCadastro).Last();
                    CarregaCampos(lastRecord);
                    AlterarEstadoFormulario(EstadoFormularioCadastro.Preenchido);
                }
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(0);
                logger.Error(ex, "Ocorreu um erro na linha {Line}", frame.GetFileLineNumber());
            }
        }

        private void linkLabelBuscarPeloNome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            RetornaFormBuscar(valuesDTOList.OrderByDescending(m => m.CodigoCadastro).ToList(), FormBuscar.TipoBusca.BuscarPeloNome);
        }

        private void linkLabelBuscarPelaMae_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            RetornaFormBuscar(valuesDTOList.OrderByDescending(m => m.CodigoCadastro).ToList(), FormBuscar.TipoBusca.BuscarPelaMae);
        }

        private void linkLabelBuscarPeloPai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            RetornaFormBuscar(valuesDTOList.OrderByDescending(m => m.CodigoCadastro).ToList(), FormBuscar.TipoBusca.BuscarPeloPai);
        }

        private void linkLabelBuscarPelaTurma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            //logger.Information("\t\tParametro entrada: {@Valor1}", "");

            RetornaFormBuscar(valuesDTOList.OrderByDescending(m => m.CodigoCadastro).ToList(), FormBuscar.TipoBusca.BuscarPelaTurma);
        }

        private void RetornaFormBuscar(List<ValuesDTO> listaValuesDTO, FormBuscar.TipoBusca tipoBusca)
        {
            try
            {
                logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
                logger.Information("\t\tParametro entrada: {@Valor1} | {@Valor2}", "listaValuesDTO", new { tipoBusca });

                FormBuscar frm = new FormBuscar(listaValuesDTO, tipoBusca);
                frm.ShowDialog();
                if (frm.Cancelado)
                {
                    logger.Information("\t\tAção: {@Valor1}", new { frm.Cancelado });
                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    return;
                }
                ValuesDTO itemAtual = new ValuesDTO();
                itemAtual = (ValuesDTO)frm.ItemSelecionado;
                logger.Information("\t\tRetorno: {@Valor1}", new { itemAtual });
                if (itemAtual == null)
                {
                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    return;
                }
                itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == itemAtual.CodigoCadastro).FirstOrDefault();
                CarregaCampos(itemAtual);

                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(0);
                logger.Error(ex, "Ocorreu um erro na linha {Line}", frame.GetFileLineNumber());
            }
        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                if (linkLabelBuscarPeloNome.Enabled) linkLabelBuscarPeloNome_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F2)
            {
                if (linkLabelBuscarPelaMae.Enabled) linkLabelBuscarPelaMae_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F3)
            {
                if (linkLabelBuscarPeloPai.Enabled) linkLabelBuscarPeloPai_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F4)
            {
                if (linkLabelBuscarPelaTurma.Enabled) linkLabelBuscarPelaTurma_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F5)
            {
                if (linkLabelAtualizarDados.Enabled) linkLabelAtualizarDados_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

            if (estadoFormularioCadastro == EstadoFormularioCadastro.Preenchido && valuesDTOAtual != null && valuesDTOAtual.NomeCrianca != null)
            {
                DialogResult result = MessageBox.Show(String.Format("Deseja aproveitar o cadastro atual de:\nMãe: {0}\nPai: {1}?\n\nClique em SIM para aproveitar, ou NÃO para iniciar novo cadastro.", valuesDTOAtual.Mae, valuesDTOAtual.Pai), "Pergunta", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AlterarEstadoFormulario(EstadoFormularioCadastro.NovoAproveitando);
                    return;
                }
            }
            AlterarEstadoFormulario(EstadoFormularioCadastro.Novo);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

            AlterarEstadoFormulario(EstadoFormularioCadastro.Alterar);
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            //TODO: ExcluirRegistro()
            try
            {
                logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

                string CodigoCadastroAtual = numericUpDown1.Value.ToString();

                if (string.IsNullOrEmpty(CodigoCadastroAtual))
                {
                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    return;
                }
                if (string.IsNullOrEmpty(TxtNomeCrianca.Text))
                {
                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    return;
                }

                DialogResult result = MessageBox.Show(string.Format("Deseja realmente remover o registro '{0} - {1}' ?", numericUpDown1.Value.ToString(), TxtNomeCrianca.Text), "Remover registro", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    numericUpDown1.Focus();
                    numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    return;
                }

                HabilitaDesabilitaCampos(false);

                Record itemAtual = recordsList.Where(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()).FirstOrDefault();
                ValuesDTO valuesDTO = itemAtual.values.Adapt<Values, ValuesDTO>();

                bool retorno = await new IntegracaoQuintaDBTrilharControle().DeletarAsync(itemAtual.id);

                if (retorno == true)
                {
                    recordsList.Remove(itemAtual);
                    valuesDTOList.RemoveAt(valuesDTOList.FindIndex(obj => obj.CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()));

                    LimparCampos();
                    MessageBox.Show(string.Format("O Código '{0}' foi removido com sucesso!", CodigoCadastroAtual), "Resultado");

                    //diminui -1 no código
                    numericUpDown1.Value = (Convert.ToInt32(CodigoCadastroAtual) - 1);
                    while (recordsList.Exists(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()) == false)
                    {
                        //enquanto não existir... 
                        //diminui um valor no código.
                        //se existir, sai...
                        numericUpDown1.Value = (Convert.ToInt32(numericUpDown1.Value) - 1);
                        if (Convert.ToInt32(numericUpDown1.Value) <= 999)
                        {
                            numericUpDown1.Value = 0000;
                            break;
                        }
                    }

                    if (recordsList.Exists(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()) == true)
                    {
                        itemAtual = recordsList.Where(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()).FirstOrDefault();
                        valuesDTO = itemAtual.values.Adapt<Values, ValuesDTO>();
                        CarregaCampos(valuesDTO);
                        numericUpDown1.Focus();
                        numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                    }
                }
                else
                {
                    HabilitaDesabilitaCampos(true);
                    MessageBox.Show(string.Format("Algo ocorreu de errado com a exclusão do registro. Tente novamente!"), "Resultado");

                }
                AlterarEstadoFormulario(EstadoFormularioCadastro.Preenchido);
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(0);
                logger.Error(ex, "Ocorreu um erro na linha {Line}", frame.GetFileLineNumber());
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

            if (estadoFormularioCadastro == EstadoFormularioCadastro.Novo || estadoFormularioCadastro == EstadoFormularioCadastro.NovoAproveitando)
            {
                SalvarNovoRegistro();
            }
            if (estadoFormularioCadastro == EstadoFormularioCadastro.Alterar)
            {
                SalvarAlteracaoRegistro();
            }
        }

        private async void SalvarNovoRegistro()
        {
            try
            {
                logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

                // TODO: SalvarNovoRegistro()
                this.BtnSalvar.Enabled = false;

                if (!VerificaCamposCadastroNovoAlterar()) return;

                ValuesDTO novoValueDTO = new ValuesDTO();
                novoValueDTO.Entity_id = "cupCkNWP1eqyoXWPtcMmoM";
                novoValueDTO.NomeCrianca = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomeCrianca.Text.ToLowerInvariant());
                novoValueDTO.DataNascimento = TxtDataNascimento.Text == "  /  /" ? "" : TxtDataNascimento.Text;
                novoValueDTO.Mae = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtMae.Text.ToLowerInvariant());
                novoValueDTO.Pai = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtPai.Text.ToLowerInvariant());
                novoValueDTO.OutroResponsavel = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtOutroResponsavel.Text.ToLowerInvariant());
                novoValueDTO.SelecioneATurma = CadastroTrilharAuxiliaresControle.RetornaValorPelaDescricaoTurmaAtual(CmbTurmaAtual.Text);
                novoValueDTO.Telefone = TxtTelefone.Text == "(  )      -" ? "" : TxtTelefone.Text;
                novoValueDTO.EnderecoEmail = TxtEmail.Text.ToLower();
                novoValueDTO.Alergia = TxtCmbAlergia.Text;
                novoValueDTO.SeAlergiaSimPreenchaAqui = TxtDescicaoAlergia.Text;
                novoValueDTO.RestrincaoAlimentar = TxtCmbRestrincaoAlimentar.Text;
                novoValueDTO.SeRestrincaoAlimentarSimDescreva = TxtDescricaoRestricaoAlimentar.Text;
                novoValueDTO.AlgumaDeficienciaOuSituacaoAtipica = TxtCmbDeficienteAtipicos.Text;
                novoValueDTO.SeAlgumaDeficienciaDescrevaOsDetalhes = TxtDescricaoDeficienteAtipicos.Text;
                novoValueDTO.Batizado = TxtCmbBatizado.Text;
                novoValueDTO.DataBatismo = TxtDataBatismo.Text == "  /  /" ? "" : TxtDataBatismo.Text;
                novoValueDTO.IgrejaBatizou = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtIgrejaBatismo.Text.ToLowerInvariant());

                logger.Information("Campos formulário: {@Valor1}", new { novoValueDTO });

                Record retornoNovoRecord = await new IntegracaoQuintaDBTrilharControle().InserirAsync<ValuesDTO>(novoValueDTO);

#if (DEBUG)
                Clipboard.SetText(retornoNovoRecord.id);
#endif

                logger.Information("Retorno: {@Valor1}", new { retornoNovoRecord });
                recordsList.Add(retornoNovoRecord);
                logger.Information("Adicionado a lista: {@Valor1}", new { retornoNovoRecord });

                ValuesDTO valuesDTO = retornoNovoRecord.values.Adapt<Values, ValuesDTO>();
                logger.Information("Retorno: {@Valor1}", new { valuesDTO });
                valuesDTO.SelecioneATurma = CadastroTrilharAuxiliaresControle.RetornaDescricaoPeloValorTurmaAtual(valuesDTO.SelecioneATurma);
                valuesDTOList.Add(valuesDTO);
                logger.Information("Adicionado a lista: {@Valor1}", new { valuesDTO });
                valuesDTOList = valuesDTOList.OrderByDescending(obj => obj.CodigoCadastro).ToList();
                CarregaCampos(valuesDTO);
                AlterarEstadoFormulario(EstadoFormularioCadastro.Preenchido);
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(0);
                logger.Error(ex, "Ocorreu um erro na linha {Line}", frame.GetFileLineNumber());
            }

        }

        private async void SalvarAlteracaoRegistro()
        {
            try
            {
                // TODO: SalvarAlteracaoRegistro()
                logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

                this.BtnSalvar.Enabled = false;

                if (!VerificaCamposCadastroNovoAlterar()) return;

                ValuesDTO alteracaoValueDTO = new ValuesDTO();
                alteracaoValueDTO.Entity_id = "cupCkNWP1eqyoXWPtcMmoM";
                alteracaoValueDTO.NomeCrianca = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomeCrianca.Text.ToLowerInvariant());
                alteracaoValueDTO.DataNascimento = TxtDataNascimento.Text == "  /  /" ? "" : TxtDataNascimento.Text;
                alteracaoValueDTO.Mae = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtMae.Text.ToLowerInvariant());
                alteracaoValueDTO.Pai = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtPai.Text.ToLowerInvariant());
                alteracaoValueDTO.OutroResponsavel = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtOutroResponsavel.Text.ToLowerInvariant());
                alteracaoValueDTO.SelecioneATurma = CadastroTrilharAuxiliaresControle.RetornaValorPelaDescricaoTurmaAtual(CmbTurmaAtual.Text);
                alteracaoValueDTO.Telefone = TxtTelefone.Text == "(  )      -" ? "" : TxtTelefone.Text;
                alteracaoValueDTO.EnderecoEmail = TxtEmail.Text.ToLower();
                alteracaoValueDTO.Alergia = TxtCmbAlergia.Text;
                alteracaoValueDTO.SeAlergiaSimPreenchaAqui = TxtDescicaoAlergia.Text;
                alteracaoValueDTO.RestrincaoAlimentar = TxtCmbRestrincaoAlimentar.Text;
                alteracaoValueDTO.SeRestrincaoAlimentarSimDescreva = TxtDescricaoRestricaoAlimentar.Text;
                alteracaoValueDTO.AlgumaDeficienciaOuSituacaoAtipica = TxtCmbDeficienteAtipicos.Text;
                alteracaoValueDTO.SeAlgumaDeficienciaDescrevaOsDetalhes = TxtDescricaoDeficienteAtipicos.Text;
                alteracaoValueDTO.Batizado = TxtCmbBatizado.Text;
                alteracaoValueDTO.DataBatismo = TxtDataBatismo.Text == "  /  /" ? "" : TxtDataBatismo.Text;
                alteracaoValueDTO.IgrejaBatizou = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtIgrejaBatismo.Text.ToLowerInvariant());

                logger.Information("Campos formulário: {@Valor1}", new { alteracaoValueDTO });

                string CodigoCadastroAtual = numericUpDown1.Value.ToString();
                Record itemAtual = recordsList.Where(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == CodigoCadastroAtual.Trim()).FirstOrDefault();

                Record retornoAlteracaoRecord = await new IntegracaoQuintaDBTrilharControle().AlterarAsync<ValuesDTO>(itemAtual.id, alteracaoValueDTO);
#if (DEBUG)
                Clipboard.SetText(retornoAlteracaoRecord.id);
#endif
                logger.Information("Retorno: {@Valor1}", new { retornoAlteracaoRecord });
                if (retornoAlteracaoRecord.id == null)
                {
                    logger.Error("O item de alteração não está disponível na sincronização. Faça a sincronização dos dados e tente novamente.");
                    MessageBox.Show("O item de alteração não está disponível na sincronização. Faça a sincronização dos dados e tente novamente.", "Resultado");

                    AlterarEstadoFormulario(EstadoFormularioCadastro.Inicio);
                    return;
                }


                recordsList.Remove(itemAtual);
                logger.Information("Removendo da lista: {@Valor1}", new { itemAtual });
                recordsList.Add(retornoAlteracaoRecord);
                logger.Information("Adicionado a lista: {@Valor1}", new { retornoAlteracaoRecord });

                valuesDTOList.RemoveAt(valuesDTOList.FindIndex(obj => obj.CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()));
                logger.Information("Removendo da lista: {@Valor1}", new { alteracaoValueDTO });

                ValuesDTO valuesDTO = retornoAlteracaoRecord.values.Adapt<Values, ValuesDTO>();
                valuesDTO.SelecioneATurma = CadastroTrilharAuxiliaresControle.RetornaDescricaoPeloValorTurmaAtual(valuesDTO.SelecioneATurma);
                valuesDTOList.Add(valuesDTO);
                logger.Information("Adicionado a lista: {@Valor1}", new { valuesDTO });
                valuesDTOList = valuesDTOList.OrderByDescending(obj => obj.CodigoCadastro).ToList();

                CarregaCampos(valuesDTO);
                AlterarEstadoFormulario(EstadoFormularioCadastro.Preenchido);
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(0);
                logger.Error(ex, "Ocorreu um erro na linha {Line}", frame.GetFileLineNumber());
            }
        }

        private bool VerificaCamposCadastroNovoAlterar()
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);
            if (string.IsNullOrEmpty(TxtNomeCrianca.Text))
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Nome da criança' não pode ser vazio!", "Resultado");
                logger.Error("\t\tRetorno: O campo 'Nome da criança' não pode ser vazio!");
                TxtNomeCrianca.Focus();
                return false;
            }
            if (TxtDataNascimento.Text == "  /  /")
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não pode ser vazio.", "Resultado");
                logger.Error("\t\tRetorno: O campo 'Data de nascimento' não pode ser vazio.");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (!TxtDataNascimento.MaskCompleted)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não está com o seu formato correto.", "Resultado");
                logger.Error("\t\tRetorno: O campo 'Data de nascimento' não está com o seu formato correto.");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (Convert.ToDateTime(TxtDataNascimento.Text).Date > DateTime.Now.Date)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não pode ser maior que hoje.", "Resultado");
                logger.Error("\t\tRetorno: O campo 'Data de nascimento' não pode ser maior que hoje.");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (Convert.ToDateTime(TxtDataNascimento.Text).Date == DateTime.Now.Date)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não deve ser igual a hoje.", "Resultado");
                logger.Error("\t\tRetorno: O campo 'Data de nascimento' não deve ser igual a hoje.");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (CmbTurmaAtual.SelectedIndex == -1)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Turma atual' deve ser preenchida.", "Resultado");
                logger.Error("\t\tRetorno: O campo 'Turma atual' deve ser preenchida.");
                CmbTurmaAtual.Focus();
                return false;
            }
            logger.Error("\t\tRetorno: Campos aprovados!");
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

            AlterarEstadoFormulario(EstadoFormularioCadastro.Cancelar);
        }

        private void TxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (TxtDataNascimento.MaskCompleted)
            {
                logger.Information("Entrou no método: {@Valor1}()", MethodBase.GetCurrentMethod().Name);

                if ((TxtDataNascimento.Text.VerificaSeDataValida() == false) ||
                    Convert.ToDateTime(TxtDataNascimento.Text).Date >= DateTime.Now.Date)
                {
                    MessageBox.Show(string.Format("A data '{0}' não é considerada uma data válida!", TxtDataNascimento.Text), "Resultado");
                    logger.Error("\t\tRetorno: " + string.Format("A data '{0}' não é considerada uma data válida!", TxtDataNascimento.Text));
                    //TxtDataNascimento.Text = "";
                    TxtIdadeCrianca.Text = "";
                    TxtTurmaAtual.Text = "";
                    CmbTurmaAtual.SelectedIndex = -1;
                    TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                    return;
                }

                if (estadoFormularioCadastro == EstadoFormularioCadastro.Novo ||
                    estadoFormularioCadastro == EstadoFormularioCadastro.NovoAproveitando ||
                    estadoFormularioCadastro == EstadoFormularioCadastro.Alterar)
                {
                    TxtIdadeCrianca.Text = DataUteis.PreencheIdadeFormatada(TxtDataNascimento.Text);
                    TxtTurmaAtual.Text = TxtDataNascimento.Text == DateTime.Now.ToShortDateString() ? "" : CadastroTrilharAuxiliaresControle.RetonaSugestaoTurma(TxtDataNascimento.Text);
                    if (TxtTurmaAtual.Text == "")
                    {
                        DialogResult result = MessageBox.Show(string.Format("Atenção!\nNão encontramos uma Turma para a idade de: '{0}'.\nDeseja prosseguir? Clique em Sim para escolher uma Turma que melhor se encaixa, ou, Não para trocar a data de nascimento.", TxtIdadeCrianca.Text), "Pergunta", MessageBoxButtons.YesNo);
                        logger.Error("\t\tRetorno: " + string.Format("Atenção!\nNão encontramos uma Turma para a idade de: '{0}'.\nDeseja prosseguir? Clique em Sim para escolher uma Turma que melhor se encaixa, ou, Não para trocar a data de nascimento.", TxtIdadeCrianca.Text));
                        if (result == DialogResult.No)
                        {
                            logger.Information("\t\tClicou em:: {@Valor1}()", "No");
                            //TxtDataNascimento.Text = "";
                            TxtIdadeCrianca.Text = "";
                            TxtTurmaAtual.Text = "";
                            CmbTurmaAtual.SelectedIndex = -1;
                            TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                            return;
                        }
                        if (result == DialogResult.Yes)
                        {
                            logger.Information("\t\tClicou em:: {@Valor1}()", "Yes");
                            CmbTurmaAtual.SelectedIndex = -1;
                            CmbTurmaAtual.Focus();
                        }
                    }
                    else
                    {
                        logger.Information("\t\tClicou em:: {@Valor1}()", "No");
                        CmbTurmaAtual.SelectedItem = TxtTurmaAtual.Text;
                    }
                }
            }
        }
    }
}
