using Mapster;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trilhar.Integracao;
using Trilhar.Entidades;

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
                case Acao.Inicio:
                    toolStripStatusLabelDiaSemana.Text = "";
                    toolStripStatusLabelDataHora.Text = "";
                    toolStripStatusLabelUltimaAtualizacao.Text = "";
                    toolStripStatusLabelTotalRegistros.Text = "";

                    TxtTurmaAtual.Visible = true;
                    CmbTurmaAtual.Visible = false;

                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(false);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);

                    linkLabelAtualizarDados.Enabled = true;

                    BtnNovo.Enabled = true;
                    //BtnAlterar.Enabled = true;
                    //BtnExcluir.Enabled = true;
                    //BtnSalvar.Enabled = true;
                    // BtnCancelar.Enabled = true;

                    TxtCodigoCadastro.Enabled = false;
                    TxtCodigoCadastro.Focus();

                    break;
                case Acao.Novo:
                    TxtTurmaAtual.Visible = false;
                    CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = true;

                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(false);
                    HabilitaDesabilitaBotoes(false);
                    LimparCampos();

                    CmbTurmaAtual.ForeColor = SystemColors.ControlText;
                    //BtnNovo.Enabled = true;
                    //BtnAlterar.Enabled = true;
                    //BtnExcluir.Enabled = true;
                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;

                    TxtTurmaAtual.BackColor = System.Drawing.SystemColors.Window;
                    TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.WindowText;

                    TxtAlergia.BackColor = System.Drawing.SystemColors.Window;
                    TxtAlergia.ForeColor = System.Drawing.SystemColors.WindowText;

                    TxtRestrincaoAlimentar.BackColor = System.Drawing.SystemColors.Window;
                    TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;

                    TxtDeficienteAtipicos.BackColor = System.Drawing.SystemColors.Window;
                    TxtDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.WindowText;

                    TxtCodigoCadastro.Enabled = false;
                    TxtNomeCrianca.Focus();
                    TxtNomeCrianca.SelectAll();
                    break;
                case Acao.Alterar:
                    TxtTurmaAtual.Visible = false;
                    CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = true;

                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(false);
                    HabilitaDesabilitaBotoes(false);

                    //BtnNovo.Enabled = true;
                    //BtnAlterar.Enabled = true;
                    //BtnExcluir.Enabled = true;
                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;

                    CarregaCampos(valuesDTOAtual);

                    //TxtTurmaAtual.BackColor = System.Drawing.SystemColors.Window;
                    //TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.WindowText;

                    //TxtAlergia.BackColor = System.Drawing.SystemColors.Window;
                    //TxtAlergia.ForeColor = System.Drawing.SystemColors.WindowText;

                    //TxtRestrincaoAlimentar.BackColor = System.Drawing.SystemColors.Window;
                    //TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;

                    //TxtDeficienteAtipicos.BackColor = System.Drawing.SystemColors.Window;
                    //TxtDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.WindowText;

                    TxtCodigoCadastro.Enabled = false;
                    TxtNomeCrianca.Focus();
                    //TxtNomeCrianca.SelectAll();
                    break;
                case Acao.Excluir:
                    break;
                case Acao.Cancelar:
                    TxtTurmaAtual.Visible = true;
                    CmbTurmaAtual.SelectedIndex = -1;
                    CmbTurmaAtual.Visible = false;

                    HabilitaDesabilitaLinkButon(true);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);

                    BtnNovo.Enabled = true;
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    //BtnSalvar.Enabled = true;
                    //BtnCancelar.Enabled = true;

                    CarregaCampos(valuesDTOAtual);

                    TxtCodigoCadastro.Enabled = true;
                    TxtCodigoCadastro.Focus();
                    TxtCodigoCadastro.SelectAll();
                    break;
                case Acao.Sincronizando:
                    HabilitaDesabilitaLinkButon(false);
                    HabilitaDesabilitaCampos(false);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);
                    LimparCampos();
                    TxtTurmaAtual.BackColor = System.Drawing.SystemColors.Window;
                    TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.WindowText;
                    break;
                case Acao.Preenchido:
                    HabilitaDesabilitaLinkButon(true);
                    HabilitaDesabilitaCampos(true);
                    ReadOnlyCampos(true);
                    HabilitaDesabilitaBotoes(false);
                    BtnNovo.Enabled = true;
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    //BtnSalvar.Enabled = true;
                    //BtnCancelar.Enabled = true;
                    TxtCodigoCadastro.Focus();
                    TxtCodigoCadastro.SelectAll();
                    break;
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
            valuesDTOAtual = itemAtual;

            TxtCodigoCadastro.Text = itemAtual != null && itemAtual.CodigoCadastro != null ? itemAtual.CodigoCadastro : "";
            TxtNomeCrianca.Text = itemAtual != null && itemAtual.NomeCrianca != null ? itemAtual.NomeCrianca : "";
            TxtNomeCrianca.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomeCrianca.Text);

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
                TxtTurmaAtual.BackColor = System.Drawing.Color.Empty;
                TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.InfoText;
                CmbTurmaAtual.ForeColor = SystemColors.ControlText;
            }

            TxtDataNascimento.Text = itemAtual != null && itemAtual.DataNascimento != null ? itemAtual.DataNascimento : "";

            string idadeFormatada = "";
            if (itemAtual != null && itemAtual.DataNascimento != null)
            {
                string data = itemAtual.DataNascimento;
                DateTime dataConvertida;

                if (DateTime.TryParse(data, out dataConvertida))
                {
                    idadeFormatada = GetAgeDetails(new DateTime(Convert.ToDateTime(itemAtual.DataNascimento).Year, Convert.ToDateTime(itemAtual.DataNascimento).Month, Convert.ToDateTime(itemAtual.DataNascimento).Day));
                    TxtIdadeCrianca.Text = idadeFormatada;
                }
                else
                {
                    TxtIdadeCrianca.Text = "";
                }


            }
            else
            {
                TxtIdadeCrianca.Text = "";
            }

            TxtMae.Text = itemAtual != null && itemAtual.Mae != null ? itemAtual.Mae : "";
            TxtMae.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtMae.Text.ToLower());

            TxtPai.Text = itemAtual != null && itemAtual.Pai != null ? itemAtual.Pai : "";
            TxtPai.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtPai.Text.ToLower());

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

            TxtTelefone.Text = itemAtual != null && itemAtual.Telefone != null ? itemAtual.Telefone : "";
            TxtEmail.Text = itemAtual != null && itemAtual.EnderecoEmail != null ? itemAtual.EnderecoEmail.ToLower() : "";
            TxtAlergia.Text = itemAtual != null && itemAtual.Alergia != null ? itemAtual.Alergia : "";
            if (TxtAlergia.Text.ToUpper() == "SIM")
            {
                this.TxtAlergia.BackColor = System.Drawing.Color.Red;
                this.TxtAlergia.ForeColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                this.TxtAlergia.BackColor = System.Drawing.Color.Empty;
                this.TxtAlergia.ForeColor = System.Drawing.SystemColors.InfoText;
            }

            TxtDescicaoAlergia.Text = itemAtual != null && itemAtual.SeAlergiaSimPreenchaAqui != null ? itemAtual.SeAlergiaSimPreenchaAqui : "";
            TxtRestrincaoAlimentar.Text = itemAtual != null && itemAtual.RestrincaoAlimentar != null ? itemAtual.RestrincaoAlimentar : "";
            if (TxtRestrincaoAlimentar.Text.ToUpper() == "SIM")
            {
                this.TxtRestrincaoAlimentar.BackColor = System.Drawing.Color.Red;
                this.TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                this.TxtRestrincaoAlimentar.BackColor = System.Drawing.Color.Empty;
                this.TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.InfoText;
            }

            TxtDescricaoRestricaoAlimentar.Text = itemAtual != null && itemAtual.SeRestrincaoAlimentarSimDescreva != null ? itemAtual.SeRestrincaoAlimentarSimDescreva : "";
            TxtDeficienteAtipicos.Text = itemAtual != null && itemAtual.AlgumaDeficienciaOuSituacaoAtipica != null ? itemAtual.AlgumaDeficienciaOuSituacaoAtipica : "";
            if (TxtDeficienteAtipicos.Text.ToUpper() == "SIM")
            {
                this.TxtDeficienteAtipicos.BackColor = System.Drawing.Color.Red;
                this.TxtDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.Info;
            }
            else
            {
                this.TxtDeficienteAtipicos.BackColor = System.Drawing.Color.Empty;
                this.TxtDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.InfoText;
            }

            TxtDescricaoDeficienteAtipicos.Text = itemAtual != null && itemAtual.SeAlgumaDeficienciaDescrevaOsDetalhes != null ? itemAtual.SeAlgumaDeficienciaDescrevaOsDetalhes : "";
        }

        public void HabilitaDesabilitaCampos(bool valor)
        {
            TxtCodigoCadastro.Enabled = valor;
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
            TxtAlergia.Enabled = valor;
            TxtDescicaoAlergia.Enabled = valor;
            TxtRestrincaoAlimentar.Enabled = valor;
            TxtDescricaoRestricaoAlimentar.Enabled = valor;
            TxtDeficienteAtipicos.Enabled = valor;
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
            TxtIdadeCrianca.ReadOnly = valor;
            TxtMae.ReadOnly = valor;
            TxtPai.ReadOnly = valor;
            TxtOutroResponsavel.ReadOnly = valor;
            TxtTelefone.ReadOnly = valor;
            TxtEmail.ReadOnly = valor;
            TxtAlergia.ReadOnly = valor;
            TxtDescicaoAlergia.ReadOnly = valor;
            TxtRestrincaoAlimentar.ReadOnly = valor;
            TxtDescricaoRestricaoAlimentar.ReadOnly = valor;
            TxtDeficienteAtipicos.ReadOnly = valor;
            TxtDescricaoDeficienteAtipicos.ReadOnly = valor;
        }

        public void LimparCampos()
        {
            TxtCodigoCadastro.ResetText();
            TxtNomeCrianca.ResetText();
            TxtTurmaAtual.ResetText();
            TxtDataNascimento.ResetText();
            TxtIdadeCrianca.ResetText();
            TxtMae.ResetText();
            TxtPai.ResetText();
            TxtOutroResponsavel.ResetText();
            TxtTelefone.ResetText();
            TxtEmail.ResetText();
            TxtAlergia.ResetText();
            TxtDescicaoAlergia.ResetText();
            TxtRestrincaoAlimentar.ResetText();
            TxtDescricaoRestricaoAlimentar.ResetText();
            TxtDeficienteAtipicos.ResetText();
            TxtDescricaoDeficienteAtipicos.ResetText();

            this.CmbTurmaAtual.BackColor = System.Drawing.SystemColors.Control;
            this.CmbTurmaAtual.ForeColor = System.Drawing.SystemColors.Window;

            this.TxtAlergia.BackColor = System.Drawing.SystemColors.Control;
            this.TxtAlergia.ForeColor = System.Drawing.SystemColors.Window;

            this.TxtRestrincaoAlimentar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.Window;

            this.TxtDeficienteAtipicos.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.Window;
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

        private void TxtCodigoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                TxtCodigoCadastro.Enabled = false;

                var itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == TxtCodigoCadastro.Text).FirstOrDefault();
                CarregaCampos(itemAtual);


                TxtCodigoCadastro.Enabled = true;
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
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
            Integracao.QuintaBDTrilhar integracaoQuintaBD = new Integracao.QuintaBDTrilhar();
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

                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
            }
            else
            {
                ValuesDTO lastRecord = valuesDTOList.OrderBy(r => r.CodigoCadastro).Last();
                CarregaCampos(lastRecord);
                HabilitaDesabilitaCampos(true);
                HabilitaDesabilitaLinkButon(true);
                HabilitaDesabilitaBotoes(true);
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;

                toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
                toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", valuesDTOList.Count);

                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
            }
        }

        private void linkLabelBuscarPeloNome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBuscar frm = new FormBuscar(valuesDTOList, FormBuscar.TipoBusca.BuscarPeloNome);
            frm.ShowDialog();
            if (frm.Cancelado)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            ValuesDTO itemAtual = new ValuesDTO();
            itemAtual = (ValuesDTO)frm.ItemSelecionado;
            if (itemAtual == null)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == itemAtual.CodigoCadastro).FirstOrDefault();
            CarregaCampos(itemAtual);

            TxtCodigoCadastro.Focus();
            TxtCodigoCadastro.SelectAll();
        }

        private void linkLabelBuscarPelaMae_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBuscar frm = new FormBuscar(valuesDTOList, FormBuscar.TipoBusca.BuscarPelaMae);
            frm.ShowDialog();
            if (frm.Cancelado)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            ValuesDTO itemAtual = new ValuesDTO();
            itemAtual = (ValuesDTO)frm.ItemSelecionado;
            if (itemAtual == null)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == itemAtual.CodigoCadastro).FirstOrDefault();
            CarregaCampos(itemAtual);

            TxtCodigoCadastro.Focus();
            TxtCodigoCadastro.SelectAll();
        }

        private void linkLabelBuscarPeloPai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBuscar frm = new FormBuscar(valuesDTOList, FormBuscar.TipoBusca.BuscarPeloPai);
            frm.ShowDialog();
            if (frm.Cancelado)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            ValuesDTO itemAtual = new ValuesDTO();
            itemAtual = (ValuesDTO)frm.ItemSelecionado;
            if (itemAtual == null)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == itemAtual.CodigoCadastro).FirstOrDefault();
            CarregaCampos(itemAtual);

            TxtCodigoCadastro.Focus();
            TxtCodigoCadastro.SelectAll();
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
            AlterarEstadoFormulario(Acao.Novo);
        }

        private async void SalvarNovoRegistro()
        {
            ValuesDTO novoValueDTO = new ValuesDTO();
            novoValueDTO.Entity_id = "cupCkNWP1eqyoXWPtcMmoM";
            novoValueDTO.NomeCrianca = TxtNomeCrianca.Text;
            novoValueDTO.DataNascimento = TxtDataNascimento.Text;
            novoValueDTO.Mae = TxtMae.Text;
            novoValueDTO.Pai = TxtPai.Text;
            novoValueDTO.OutroResponsavel = TxtOutroResponsavel.Text;
            novoValueDTO.SelecioneATurma = RetornaValorCmbTurmaAtual(CmbTurmaAtual.Text);
            novoValueDTO.Telefone = TxtTelefone.Text;
            novoValueDTO.EnderecoEmail = TxtEmail.Text.ToLower();
            novoValueDTO.Alergia = TxtAlergia.Text;
            novoValueDTO.SeAlergiaSimPreenchaAqui = TxtDescicaoAlergia.Text;
            novoValueDTO.RestrincaoAlimentar = TxtRestrincaoAlimentar.Text;
            novoValueDTO.SeRestrincaoAlimentarSimDescreva = TxtDescricaoRestricaoAlimentar.Text;
            novoValueDTO.AlgumaDeficienciaOuSituacaoAtipica = TxtDeficienteAtipicos.Text;
            novoValueDTO.SeAlgumaDeficienciaDescrevaOsDetalhes = TxtDescricaoDeficienteAtipicos.Text;
            novoValueDTO.Batizado = "SIM";
            novoValueDTO.DataBatismo = "10/12/2020";
            novoValueDTO.IgrejaBatizou = "IGREJA BETEL BRASILEIRO";

            Record retornoNovoRecord = await new QuintaBDTrilhar().PostAsync<ValuesDTO>(novoValueDTO);
            recordsList.Add(retornoNovoRecord);

            ValuesDTO valuesDTO = retornoNovoRecord.values.Adapt<Values, ValuesDTO>();
            valuesDTOList.Add(valuesDTO);
            valuesDTOList = valuesDTOList.OrderByDescending(obj => obj.CodigoCadastro).ToList();
            CarregaCampos(valuesDTO);
            AlterarEstadoFormulario(Acao.Preenchido);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            AlterarEstadoFormulario(Acao.Alterar);
        }

        private async void SalvarAlteracaoRegistro()
        {
            ValuesDTO novoValueDTO = new ValuesDTO();
            novoValueDTO.Entity_id = "cupCkNWP1eqyoXWPtcMmoM";
            novoValueDTO.NomeCrianca = TxtNomeCrianca.Text;
            novoValueDTO.DataNascimento = TxtDataNascimento.Text;
            novoValueDTO.Mae = TxtMae.Text;
            novoValueDTO.Pai = TxtPai.Text;
            novoValueDTO.OutroResponsavel = TxtOutroResponsavel.Text;
            novoValueDTO.SelecioneATurma = RetornaValorCmbTurmaAtual(CmbTurmaAtual.Text);
            novoValueDTO.Telefone = TxtTelefone.Text;
            novoValueDTO.EnderecoEmail = TxtEmail.Text.ToLower();
            novoValueDTO.Alergia = TxtAlergia.Text;
            novoValueDTO.SeAlergiaSimPreenchaAqui = TxtDescicaoAlergia.Text;
            novoValueDTO.RestrincaoAlimentar = TxtRestrincaoAlimentar.Text;
            novoValueDTO.SeRestrincaoAlimentarSimDescreva = TxtDescricaoRestricaoAlimentar.Text;
            novoValueDTO.AlgumaDeficienciaOuSituacaoAtipica = TxtDeficienteAtipicos.Text;
            novoValueDTO.SeAlgumaDeficienciaDescrevaOsDetalhes = TxtDescricaoDeficienteAtipicos.Text;
            novoValueDTO.Batizado = "SIM";
            novoValueDTO.DataBatismo = "10/12/2020";
            novoValueDTO.IgrejaBatizou = "IGREJA BETEL BRASILEIRO";

            Record retornoNovoRecord = await new QuintaBDTrilhar().PostAsync<ValuesDTO>(novoValueDTO);
            recordsList.Add(retornoNovoRecord);

            ValuesDTO valuesDTO = retornoNovoRecord.values.Adapt<Values, ValuesDTO>();
            valuesDTOList.Add(valuesDTO);
            valuesDTOList = valuesDTOList.OrderByDescending(obj => obj.CodigoCadastro).ToList();

            CarregaCampos(valuesDTO);
            HabilitaDesabilitaCampos(true);
            TxtCodigoCadastro.Focus();
            TxtCodigoCadastro.SelectAll();
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

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            string CodigoCadastroAtual = TxtCodigoCadastro.Text;

            if (string.IsNullOrEmpty(TxtCodigoCadastro.Text))
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }
            if (string.IsNullOrEmpty(TxtNomeCrianca.Text))
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }

            DialogResult result = MessageBox.Show(string.Format("Deseja realmente remover o registro '{0} - {1}' ?", TxtCodigoCadastro.Text, TxtNomeCrianca.Text), "Remover registro", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                TxtCodigoCadastro.Focus();
                TxtCodigoCadastro.SelectAll();
                return;
            }

            HabilitaDesabilitaCampos(false);

            Record itemAtual = recordsList.Where(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == TxtCodigoCadastro.Text.Trim()).FirstOrDefault();
            ValuesDTO valuesDTO = itemAtual.values.Adapt<Values, ValuesDTO>();
            bool retorno = await new QuintaBDTrilhar().DeleteAsync(itemAtual.id);
            if (retorno == true)
            {
                recordsList.Remove(itemAtual);
                valuesDTOList.RemoveAt(valuesDTOList.FindIndex(obj => obj.CodigoCadastro.Trim() == TxtCodigoCadastro.Text.Trim()));

                LimparCampos();
                MessageBox.Show(string.Format("O Código '{0}' foi removido com sucesso!", CodigoCadastroAtual), "Resultado");

                //diminui -1 no código
                TxtCodigoCadastro.Text = (Convert.ToInt32(CodigoCadastroAtual) - 1).ToString();
                while (recordsList.Exists(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == TxtCodigoCadastro.Text.Trim()) == false)
                {
                    //enquanto não existir... 
                    //diminui um valor no código.
                    //se existir, sai...
                    TxtCodigoCadastro.Text = (Convert.ToInt32(TxtCodigoCadastro.Text) - 1).ToString();
                    if (Convert.ToInt32(TxtCodigoCadastro.Text) <= 999)
                    {
                        break;
                    }
                }

                if (recordsList.Exists(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == TxtCodigoCadastro.Text.Trim()) == true)
                {
                    itemAtual = recordsList.Where(obj => obj.values.Adapt<Values, ValuesDTO>().CodigoCadastro.Trim() == TxtCodigoCadastro.Text.Trim()).FirstOrDefault();
                    valuesDTO = itemAtual.values.Adapt<Values, ValuesDTO>();
                    CarregaCampos(valuesDTO);
                    TxtCodigoCadastro.Focus();
                    TxtCodigoCadastro.SelectAll();
                }
            }
            else
            {
                HabilitaDesabilitaCampos(true);
                MessageBox.Show(string.Format("Algo ocorreu de errado com a exclusão do registro. Tente novamente!"), "Resultado");

            }

            HabilitaDesabilitaCampos(true);
            TxtCodigoCadastro.Focus();
            TxtCodigoCadastro.SelectAll();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (GetAcao == Acao.Novo)
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
    }
}
