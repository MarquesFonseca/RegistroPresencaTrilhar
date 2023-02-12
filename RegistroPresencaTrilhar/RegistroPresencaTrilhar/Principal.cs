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

namespace RegistroPresencaTrilhar
{
    public partial class Principal : Form
    {
        List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            TypeAdapterConfig<Values, ValuesDTO>.NewConfig()
            .Map(dest => dest.CodigoCadastro, src => src.dcPfSQWPrdP4o2ccRdLNKz)
            .Map(dest => dest.NomeCrianca, src => src.cluCkFshndGzatxtRcKSoa)
            .Map(dest => dest.DataNascimento, src => src.axdSotECjbuzdcLGtdHfTI)
            .Map(dest => dest.Mae, src => src.dcJSoRWPndIOkjqSkTbCk5)
            .Map(dest => dest.Pai, src => src.bAfHJcV8njWOGiWQztd8ks)
            .Map(dest => dest.OutroResponsavel, src => src.dcRCkpW59gl4k4cCojWPO1)
            .Map(dest => dest.SelecioneATurma, src => src.cRWPtcLSjijORdRCo5WRnR)
            .Map(dest => dest.Telefone, src => src.crWO5aWQTcMOk0W4hcRHOo)
            .Map(dest => dest.EnderecoEmail, src => src.dcJmoAW5vdHBKBsCkGvh4k)
            .Map(dest => dest.Alergia, src => src.bWWQqIfuLpW43dMtRcG8oN)
            .Map(dest => dest.SeAlergiaSimPreenchaAqui, src => src.ddIN7cMCneAA9hW7OeAa0i)
            .Map(dest => dest.RestrincaoAlimentar, src => src.bsWOS1bwPegikrWQ3cGSob)
            .Map(dest => dest.SeRestrincaoAlimentarSimDescreva, src => src.ddMCowu8nnkykKW65JESoi)
            .Map(dest => dest.AlgumaDeficienciaOuSituacaoAtipica, src => src.bNF2CMbHPldQ9zWQRdJx1w)
            .Map(dest => dest.SeAlgumaDeficienciaDescrevaOsDetalhes, src => src.c1dmoHWPHcpioPW43cN8oA)
            .Map(dest => dest.Batizado, src => src.cdo8kfWODhW4GCW6LwjmoG)
            .Map(dest => dest.DataBatismo, src => src.cAq1TbESnlW6z7tJlcKCk9)
            .Map(dest => dest.IgrejaBatizou, src => src.dcT8kfWQfcGOkifJXub0ir)
            .Map(dest => dest.ChamadaAzul_9_10Anos, src => src.cxfGFlCnhzyk1W6pdKmow)
            .Map(dest => dest.ChamadaAzulRoyal_11_12Anos, src => src.c9WQVdTCjjW6NcSaqPW7HL)
            .Map(dest => dest.ChamadaBranco_0_11Me29D, src => src.cyW4r8W7DhW6ZcS8kjW6fy)
            .Map(dest => dest.ChamadaLaranja_3_4Anos, src => src.bIl2VcHSjlc4ohW7pcV1CY)
            .Map(dest => dest.ChamadaLilas_1Ano, src => src.bDWQ1zleTdyRNdJwtdVmkx)
            .Map(dest => dest.ChamadaLilas_2_Anos, src => src.dcGZGaW7PcG4obW7jJWOXy)
            .Map(dest => dest.ChamadaVerde_7_8Anos, src => src.cVF8kHn0TcT7KoWQicW41V)
            .Map(dest => dest.ChamadaVermelho_5_6Anos, src => src.dcTx07W7jdSioSj1JdL8kD);

            AtualizaDados();

            toolStripStatusLabelDiaSemana.Text = "";
            toolStripStatusLabelDataHora.Text = "";
            toolStripStatusLabelUltimaAtualizacao.Text = "";
            toolStripStatusLabelTotalRegistros.Text = "";

            clock.Start();

            TxtCodigoCadastro.Enabled = false;
            TxtCodigoCadastro.Focus();
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

        private void CarregaCampos(ValuesDTO itemAtual)
        {
            TxtCodigoCadastro.Text = itemAtual != null && itemAtual.CodigoCadastro != null ? itemAtual.CodigoCadastro : "";
            TxtNomeCrianca.Text = itemAtual != null && itemAtual.NomeCrianca != null ? itemAtual.NomeCrianca : "";
            TxtNomeCrianca.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomeCrianca.Text);

            if (itemAtual != null && itemAtual.SelecioneATurma != null)
            {
                TxtTurmaAtual.Text = itemAtual.SelecioneATurma;

                if (TxtTurmaAtual.Text.ToUpper().Contains("LILÁS (1 ano)".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(200, 162, 200);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("LILÁS (2 ANOS)".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(153, 50, 204);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.Info;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("LARANJA".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(255, 165, 0);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.Info;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("VERMELHO".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(255, 0, 0);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.Info;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("VERDE".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(0, 255, 100);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("AZUL".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(173, 216, 230);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.ControlText;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("AZUL ROYAL".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(0, 0, 128);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.Info;
                }
                if (TxtTurmaAtual.Text.ToUpper().Contains("ROSA".ToUpper()))
                {
                    this.TxtTurmaAtual.BackColor = Color.FromArgb(255, 192, 203);
                    this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.ControlText;
                }
            }
            else
            {
                TxtTurmaAtual.Text = "";
            }


            TxtDataNascimento.Text = itemAtual != null && itemAtual.DataNascimento != null ? itemAtual.DataNascimento : "";

            string idadeFormatada = "";
            if (itemAtual != null && itemAtual.DataNascimento != null)
            {

                idadeFormatada = GetAgeDetails(new DateTime(Convert.ToDateTime(itemAtual.DataNascimento).Year, Convert.ToDateTime(itemAtual.DataNascimento).Month, Convert.ToDateTime(itemAtual.DataNascimento).Day));
                TxtIdadeCrianca.Text = idadeFormatada;
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

        private void linkLabelAtualizarDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AtualizaDados();
        }

        public async void AtualizaDados()
        {
            valuesDTOList = new List<ValuesDTO>();
            HabilitaDesabilitaCampos(false);

            //string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
            string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&fetch_all=true&page=";

            int i = 0;
            while (true)
            {
                if (!CheckForInternetConnection())
                {
                    MessageBox.Show("Sem conexão com internet no momento!");
                    break;
                }
                string novoI = (i + 1).ToString();
                string novoURI = URI + novoI;
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(novoURI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(ProdutoJsonString);

                            if (myDeserializedClass.records.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                foreach (Record record in myDeserializedClass.records)
                                {
                                    var valuesDTO = record.values.Adapt<ValuesDTO>();
                                    valuesDTOList.Add(valuesDTO);

                                    toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
                                    toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", valuesDTOList.Count);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível obter os registros : " + response.StatusCode);
                        }
                    }
                }
                i++;
            }

            if (valuesDTOList == null || valuesDTOList.Count == 0)
            {
                HabilitaDesabilitaCampos(true);

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
                toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
                toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", valuesDTOList.Count);

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

        public void HabilitaDesabilitaCampos(bool valor)
        {
            linkLabelBuscarPeloNome.Enabled = valor;
            linkLabelBuscarPelaMae.Enabled = valor;
            linkLabelBuscarPeloPai.Enabled = valor;
            linkLabelAtualizarDados.Enabled = valor;
            TxtCodigoCadastro.Enabled = valor;
            TxtNomeCrianca.Enabled = valor;
            TxtTurmaAtual.Enabled = valor;
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

        public string GetAgeDetails(DateTime dob)
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

        private void clock_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDiaSemana.Text = DateTime.Now.ToLongDateString().ToString();
            toolStripStatusLabelDataHora.Text = DateTime.Now.ToLongTimeString().ToString();
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
    }
}
