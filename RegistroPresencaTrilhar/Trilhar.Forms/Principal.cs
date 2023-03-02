using System;
using System.Net;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Mapster;
using Trilhar.Entidades;
using Trilhar.Integracao;
using Trilhar.Uteis;

namespace Trilhar.Forms
{
    public partial class Principal : Form, ICloneable
    {
        List<Record> recordsList = new List<Record>();
        List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();
        ValuesDTO valuesDTOAtual = new ValuesDTO();

        public Acao GetAcao;

        public enum Acao
        {
            Inicio,
            Novo,
            NovoAproveitando,
            Alterar,
            Excluir,
            Sincronizando,
            Preenchido,
            Cancelar
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            clock.Start();

            AlterarEstadoFormulario(Acao.Inicio);

            //AtualizaDados();           
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDiaSemana.Text = DateTime.Now.ToLongDateString().ToString();
            toolStripStatusLabelDataHora.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void AlterarEstadoFormulario(Acao acao)
        {
            GetAcao = acao;
            switch (acao)
            {
                #region Acao.Inicio
                case Acao.Inicio:
                    // TODO: Acao.Inicio:
                    toolStripStatusLabelDiaSemana.Text = "";
                    toolStripStatusLabelDataHora.Text = "";
                    toolStripStatusLabelUltimaAtualizacao.Text = "";
                    toolStripStatusLabelTotalRegistros.Text = "";

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
                case Acao.Novo:
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
                case Acao.NovoAproveitando:
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
                case Acao.Alterar:
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
                case Acao.Excluir:
                    // TODO: Acao.Excluir:
                    break;
                #endregion
                #region Acao.Cancelar
                case Acao.Cancelar:
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

                    AlterarEstadoFormulario(Acao.Preenchido);
                    break;
                #endregion
                #region Acao.Sincronizando
                case Acao.Sincronizando:
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
                case Acao.Preenchido:
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
            BtnNovo.Enabled = valor;
            BtnAlterar.Enabled = valor;
            BtnExcluir.Enabled = valor;
            BtnCancelar.Enabled = valor;
            BtnSalvar.Enabled = valor;
        }

        private void CarregaCampos(ValuesDTO itemAtual)
        {
            //TODO: CarregaCampos()
            valuesDTOAtual = itemAtual;

            #region CodigoCadastro
            numericUpDown1.Value = itemAtual != null && itemAtual.CodigoCadastro != null
                    ? Convert.ToDecimal(itemAtual.CodigoCadastro)
                    : 0000;

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
                    AlterarEstadoFormulario(Acao.Inicio);
                    return;
                }
            }

            TxtDataNascimento.Text = itemAtual != null && itemAtual.DataNascimento != null ? itemAtual.DataNascimento : "";
            TxtIdadeCrianca.Text = PreencheIdadeFormatada(TxtDataNascimento.Text);
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

        private string PreencheIdadeFormatada(string dataNascimento)
        {
            if (dataNascimento == DateTime.Now.ToShortDateString()) return "";

            string idadeFormatada = "";
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNascimento, out dataConvertida))
            {
                idadeFormatada = GetAgeDetails(new DateTime(Convert.ToDateTime(dataNascimento).Year, Convert.ToDateTime(dataNascimento).Month, Convert.ToDateTime(dataNascimento).Day));
                return idadeFormatada;
            }
            else
            {
                return "";
            }
        }

        public void HabilitaDesabilitaCampos(bool valor)
        {
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
            linkLabelBuscarPeloNome.Enabled = valor;
            linkLabelBuscarPelaMae.Enabled = valor;
            linkLabelBuscarPeloPai.Enabled = valor;
            linkLabelAtualizarDados.Enabled = valor;
        }

        public void ReadOnlyCampos(bool valor)
        {
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

        private string GetAgeDetails(DateTime dob)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dob.Year;
            int month = today.Month - dob.Month;
            int day = today.Day - dob.Day;

            if (month < 0)
            {
                age--;
                month = 12 + month;
            }

            if (day < 0)
            {
                month--;
                day = DateTime.DaysInMonth(today.Year, today.Month - 1) + day;
            }

            return string.Format("{0} anos, {1} meses e {2} dias", age, month, day);
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                numericUpDown1.Enabled = false;

                var itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == numericUpDown1.Text).FirstOrDefault();
                CarregaCampos(itemAtual);
                AlterarEstadoFormulario(Acao.Preenchido);

                if (itemAtual != null)
                    numericUpDown1.Value = Convert.ToDecimal(itemAtual.CodigoCadastro);

                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
            }
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void linkLabelAtualizarDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlterarEstadoFormulario(Acao.Sincronizando);

            AtualizaDados();
        }

        public async void AtualizaDados()
        {
            //TODO: AtualizaDados()
            QuintaBDTrilhar integracaoQuintaBD = new QuintaBDTrilhar();
            recordsList = await integracaoQuintaBD.GetListAsync();
            valuesDTOList = integracaoQuintaBD.GetListValues(recordsList);

            if (valuesDTOList == null || valuesDTOList.Count == 0)
            {
                //HabilitaDesabilitaCampos(false);
                linkLabelAtualizarDados.Enabled = true;
                BtnNovo.Enabled = true;
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;

                toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
                toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", 0);

                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
            }
            else
            {
                ValuesDTO lastRecord = valuesDTOList.OrderBy(r => r.CodigoCadastro).Last();
                CarregaCampos(lastRecord);
                AlterarEstadoFormulario(Acao.Preenchido);

                toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
                toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", valuesDTOList.Count);
            }
        }

        private void linkLabelBuscarPeloNome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBuscar frm = new FormBuscar(valuesDTOList, FormBuscar.TipoBusca.BuscarPeloNome);
            frm.ShowDialog();
            if (frm.Cancelado)
            {
                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                return;
            }
            ValuesDTO itemAtual = new ValuesDTO();
            itemAtual = (ValuesDTO)frm.ItemSelecionado;
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

        private void linkLabelBuscarPelaMae_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBuscar frm = new FormBuscar(valuesDTOList, FormBuscar.TipoBusca.BuscarPelaMae);
            frm.ShowDialog();
            if (frm.Cancelado)
            {
                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                return;
            }
            ValuesDTO itemAtual = new ValuesDTO();
            itemAtual = (ValuesDTO)frm.ItemSelecionado;
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

        private void linkLabelBuscarPeloPai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBuscar frm = new FormBuscar(valuesDTOList, FormBuscar.TipoBusca.BuscarPeloPai);
            frm.ShowDialog();
            if (frm.Cancelado)
            {
                numericUpDown1.Focus();
                numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
                return;
            }
            ValuesDTO itemAtual = new ValuesDTO();
            itemAtual = (ValuesDTO)frm.ItemSelecionado;
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

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                if (linkLabelBuscarPeloNome.Enabled)
                    linkLabelBuscarPeloNome_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F2)
            {
                if (linkLabelBuscarPelaMae.Enabled)
                    linkLabelBuscarPelaMae_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F3)
            {
                if (linkLabelBuscarPeloPai.Enabled)
                    linkLabelBuscarPeloPai_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.F5)
            {
                if (linkLabelAtualizarDados.Enabled)
                    linkLabelAtualizarDados_LinkClicked(null, null);
            }
            if (e.KeyData == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar a aplicação?", "Fechar Aplicação", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (GetAcao == Acao.Preenchido && valuesDTOAtual != null && valuesDTOAtual.NomeCrianca != null)
            {
                DialogResult result = MessageBox.Show(String.Format("Deseja aproveitar o cadastro atual de:\nMãe: {0}\nPai: {1}?\n\nClique em SIM para aproveitar, ou NÃO para iniciar novo cadastro.", valuesDTOAtual.Mae, valuesDTOAtual.Pai), "Pergunta", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AlterarEstadoFormulario(Acao.NovoAproveitando);
                    return;
                }
            }
            AlterarEstadoFormulario(Acao.Novo);
        }

        private async void SalvarNovoRegistro()
        {
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
            novoValueDTO.SelecioneATurma = RetornaValorCmbTurmaAtual(CmbTurmaAtual.Text);
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

            Record retornoNovoRecord = await new QuintaBDTrilhar().PostAsync<ValuesDTO>(novoValueDTO);
            recordsList.Add(retornoNovoRecord);

            ValuesDTO valuesDTO = retornoNovoRecord.values.Adapt<Values, ValuesDTO>();
            valuesDTO.SelecioneATurma = RetornaDescricaoCmbTurmaAtual(valuesDTO.SelecioneATurma);
            valuesDTOList.Add(valuesDTO);
            valuesDTOList = valuesDTOList.OrderByDescending(obj => obj.CodigoCadastro).ToList();
            CarregaCampos(valuesDTO);
            AlterarEstadoFormulario(Acao.Preenchido);
        }

        private bool VerificaCamposCadastroNovoAlterar()
        {
            if (string.IsNullOrEmpty(TxtNomeCrianca.Text))
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Nome da criança' não pode ser vazio!", "Resultado");
                TxtNomeCrianca.Focus();
                return false;
            }
            if (TxtDataNascimento.Text == "  /  /")
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não pode ser vazio.", "Resultado");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (!TxtDataNascimento.MaskCompleted)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não está com o seu formato correto.", "Resultado");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (Convert.ToDateTime(TxtDataNascimento.Text).Date > DateTime.Now.Date)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não pode ser maior que hoje.", "Resultado");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (Convert.ToDateTime(TxtDataNascimento.Text).Date == DateTime.Now.Date)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Data de nascimento' não deve ser igual a hoje.", "Resultado");
                TxtDataNascimento.Focus();
                TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                return false;
            }
            if (CmbTurmaAtual.SelectedIndex == -1)
            {
                this.BtnSalvar.Enabled = true;
                MessageBox.Show("O campo 'Turma atual' deve ser preenchida.", "Resultado");
                CmbTurmaAtual.Focus();
                return false;
            }
            return true;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            AlterarEstadoFormulario(Acao.Alterar);
        }

        private async void SalvarAlteracaoRegistro()
        {
            // TODO: SalvarAlteracaoRegistro()
            this.BtnSalvar.Enabled = false;

            if (!VerificaCamposCadastroNovoAlterar()) return;

            ValuesDTO alteracaoValueDTO = new ValuesDTO();
            alteracaoValueDTO.Entity_id = "cupCkNWP1eqyoXWPtcMmoM";
            alteracaoValueDTO.NomeCrianca = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomeCrianca.Text.ToLowerInvariant());
            alteracaoValueDTO.DataNascimento = TxtDataNascimento.Text == "  /  /" ? "" : TxtDataNascimento.Text;
            alteracaoValueDTO.Mae = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtMae.Text.ToLowerInvariant());
            alteracaoValueDTO.Pai = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtPai.Text.ToLowerInvariant());
            alteracaoValueDTO.OutroResponsavel = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtOutroResponsavel.Text.ToLowerInvariant());
            alteracaoValueDTO.SelecioneATurma = RetornaValorCmbTurmaAtual(CmbTurmaAtual.Text);
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

            string CodigoCadastroAtual = numericUpDown1.Value.ToString();
            Record itemAtual = recordsList.Where(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == CodigoCadastroAtual.Trim()).FirstOrDefault();

            Record retornoAlteracaoRecord = await new QuintaBDTrilhar().PutAsync<ValuesDTO>(itemAtual.id, alteracaoValueDTO);
            if (retornoAlteracaoRecord.id == null)
            {
                MessageBox.Show("O item de alteração não está disponível na sincronização. Faça a sincronização dos dados e tente novamente.", "Resultado");

                AlterarEstadoFormulario(Acao.Inicio);
                return;
            }

            recordsList.Remove(itemAtual);
            recordsList.Add(retornoAlteracaoRecord);

            valuesDTOList.RemoveAt(valuesDTOList.FindIndex(obj => obj.CodigoCadastro.Trim() == numericUpDown1.Value.ToString().Trim()));
            ValuesDTO valuesDTO = retornoAlteracaoRecord.values.Adapt<Values, ValuesDTO>();
            valuesDTO.SelecioneATurma = RetornaDescricaoCmbTurmaAtual(valuesDTO.SelecioneATurma);
            valuesDTOList.Add(valuesDTO);
            valuesDTOList = valuesDTOList.OrderByDescending(obj => obj.CodigoCadastro).ToList();

            CarregaCampos(valuesDTO);
            AlterarEstadoFormulario(Acao.Preenchido);
        }

        private string RetornaValorCmbTurmaAtual(string text)
        {
            if (text == "BRANCO/ROSA (0 A 11 M)") { return "BRANCO/ROSA (0 A 11 M)"; }
            if (text == "LILÁS (1 ANO)") { return "LILÁS (1 ANO)"; }
            if (text == "LILÁS (2 ANOS)") { return "LILÁS (2 ANOS)"; }
            if (text == "LARANJA 3-4 ANOS") { return "LARANJA"; }
            if (text == "VERMELHO 5-6 ANOS") { return "VERMELHO"; }
            if (text == "VERDE 7-8 ANOS") { return "VERDE"; }
            if (text == "AZUL 9-10 ANOS") { return "AZUL (9-10 ANOS)"; }
            if (text == "AZUL ROYAL 11-12 ANOS") { return "AZUL ROYAL (11-12 ANOS)"; }

            return "";
        }

        private string RetornaDescricaoCmbTurmaAtual(string Valor)
        {
            if (Valor == "BRANCO/ROSA (0 A 11 M)") { return "BRANCO/ROSA (0 A 11 M)"; }
            if (Valor == "LILÁS (1 ANO)") { return "LILÁS (1 ANO)"; }
            if (Valor == "LILÁS (2 ANOS)") { return "LILÁS (2 ANOS)"; }
            if (Valor == "LARANJA") { return "LARANJA 3-4 ANOS"; }
            if (Valor == "VERMELHO") { return "VERMELHO 5-6 ANOS"; }
            if (Valor == "VERDE") { return "VERDE 7-8 ANOS"; }
            if (Valor == "AZUL (9-10 ANOS)") { return "AZUL 9-10 ANOS"; }
            if (Valor == "AZUL ROYAL (11-12 ANOS)") { return "AZUL ROYAL 11-12 ANOS"; }

            return "";
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            //TODO: ExcluirRegistro()
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
            bool retorno = await new QuintaBDTrilhar().DeleteAsync(itemAtual.id);
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
            AlterarEstadoFormulario(Acao.Preenchido);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (GetAcao == Acao.Novo || GetAcao == Acao.NovoAproveitando)
            {
                SalvarNovoRegistro();
            }
            if (GetAcao == Acao.Alterar)
            {
                SalvarAlteracaoRegistro();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            AlterarEstadoFormulario(Acao.Cancelar);
        }

        private string RetonaSugestaoTurma(string dataNascimento)
        {
            #region verifica BRANCO/ROSA (0 A 11 M)
            if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2022", limiteSuperior: DateTime.Now.Date.ToShortDateString()))
                return "BRANCO/ROSA (0 A 11 M)";
            #endregion

            #region LILÁS (1 ANO)
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2021", limiteSuperior: "28/02/2022"))
                return "LILÁS (1 ANO)";
            #endregion

            #region LILÁS (2 ANOS)
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2020", limiteSuperior: "28/02/2021"))
                return "LILÁS (2 ANOS)";
            #endregion

            #region LARANJA 3-4 ANOS
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2018", limiteSuperior: "29/02/2020"))
                return "LARANJA 3-4 ANOS";
            #endregion

            #region VERMELHO 5-6 ANOS
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2016", limiteSuperior: "28/02/2018"))
                return "VERMELHO 5-6 ANOS";
            #endregion

            #region VERDE 7-8 ANOS
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2014", limiteSuperior: "29/02/2016"))
                return "VERDE 7-8 ANOS";
            #endregion

            #region AZUL 9-10 ANOS
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2012", limiteSuperior: "28/02/2014"))
                return "AZUL 9-10 ANOS";
            #endregion

            #region AZUL ROYAL 11-12 ANOS
            else if (VerificaPeriodoTurma(data: dataNascimento, limiteInferior: "01/03/2010", limiteSuperior: "29/02/2012"))
                return "AZUL ROYAL 11-12 ANOS";
            #endregion

            #region nenhuma das opções
            else
                return "";
            #endregion
        }

        private bool VerificaPeriodoTurma(string data, string limiteInferior, string limiteSuperior)
        {
            try
            {
                DateTime dataObj = DateTime.ParseExact(data, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                DateTime limiteInfObj = DateTime.ParseExact(limiteInferior, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                DateTime limiteSupObj = DateTime.ParseExact(limiteSuperior, "dd/MM/yyyy", new CultureInfo("pt-BR"));

                if (dataObj >= limiteInfObj && dataObj <= limiteSupObj)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void TxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (TxtDataNascimento.MaskCompleted)
            {
                if ((TxtDataNascimento.Text.VerificaSeDataValida() == false) ||
                    Convert.ToDateTime(TxtDataNascimento.Text).Date >= DateTime.Now.Date)
                {
                    MessageBox.Show(string.Format("A data '{0}' não é considerada uma data válida!", TxtDataNascimento.Text), "Resultado");
                    //TxtDataNascimento.Text = "";
                    TxtIdadeCrianca.Text = "";
                    TxtTurmaAtual.Text = "";
                    CmbTurmaAtual.SelectedIndex = -1;
                    TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                    return;
                }

                if (GetAcao == Acao.Novo || GetAcao == Acao.Alterar)
                {
                    TxtIdadeCrianca.Text = PreencheIdadeFormatada(TxtDataNascimento.Text);
                    TxtTurmaAtual.Text = TxtDataNascimento.Text == DateTime.Now.ToShortDateString() ? "" : RetonaSugestaoTurma(TxtDataNascimento.Text);
                    if (TxtTurmaAtual.Text == "")
                    {
                        DialogResult result = MessageBox.Show(string.Format("Atenção!\nNão encontramos uma Turma para a idade de: '{0}'.\nDeseja prosseguir? Clique em Sim para escolher uma Turma que melhor se encaixa, ou, Não para trocar a data de nascimento.", TxtIdadeCrianca.Text), "Pergunta", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            //TxtDataNascimento.Text = "";
                            TxtIdadeCrianca.Text = "";
                            TxtTurmaAtual.Text = "";
                            CmbTurmaAtual.SelectedIndex = -1;
                            TxtDataNascimento.Select(0, TxtDataNascimento.Text.Length);
                            return;
                        }
                        if (result == DialogResult.Yes)
                        {
                            CmbTurmaAtual.SelectedIndex = -1;
                            CmbTurmaAtual.Focus();
                        }
                    }
                    else
                    {
                        CmbTurmaAtual.SelectedItem = TxtTurmaAtual.Text;
                    }
                }
            }
        }
    }
}
