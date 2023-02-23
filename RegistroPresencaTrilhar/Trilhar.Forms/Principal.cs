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

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
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
            HabilitaDesabilitaCampos(false);

            Integracao.QuintaBDTrilhar integracaoQuintaBD = new Integracao.QuintaBDTrilhar();
            recordsList = await integracaoQuintaBD.GetListAsync();
            valuesDTOList = integracaoQuintaBD.GetListValues(recordsList);

            if (valuesDTOList == null || valuesDTOList.Count == 0)
            {
                HabilitaDesabilitaCampos(false);
                LimparCampos();
                linkLabelAtualizarDados.Enabled = true;

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
            return;




            //valuesDTOList = new List<ValuesDTO>();
            //HabilitaDesabilitaCampos(false);

            ////string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
            //string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&fetch_all=true&page=";

            //int i = 0;
            //while (true)
            //{
            //    if (!CheckForInternetConnection())
            //    {
            //        MessageBox.Show("Sem conexão com internet no momento!");
            //        break;
            //    }
            //    string novoI = (i + 1).ToString();
            //    string novoURI = URI + novoI;
            //    using (var client = new HttpClient())
            //    {
            //        using (var response = await client.GetAsync(novoURI))
            //        {
            //            if (response.IsSuccessStatusCode)
            //            {
            //                var ProdutoJsonString = await response.Content.ReadAsStringAsync();
            //                CadastroTrilhar myDeserializedClass = JsonConvert.DeserializeObject<CadastroTrilhar>(ProdutoJsonString);

            //                if (myDeserializedClass.records.Count == 0)
            //                {
            //                    break;
            //                }
            //                else
            //                {
            //                    foreach (Record record in myDeserializedClass.records)
            //                    {
            //                        var valuesDTO = record.values.Adapt<ValuesDTO>();

            //                        valuesDTOList.Add(valuesDTO);

            //                        toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
            //                        toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", valuesDTOList.Count);
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Não foi possível obter os registros : " + response.StatusCode);
            //            }
            //        }
            //    }
            //    i++;
            //}

            //if (valuesDTOList == null || valuesDTOList.Count == 0)
            //{
            //    HabilitaDesabilitaCampos(true);

            //    toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
            //    toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", 0);

            //    TxtCodigoCadastro.Focus();
            //    TxtCodigoCadastro.SelectAll();
            //}
            //else
            //{
            //    ValuesDTO lastRecord = valuesDTOList.OrderBy(r => r.CodigoCadastro).Last();
            //    CarregaCampos(lastRecord);
            //    HabilitaDesabilitaCampos(true);
            //    toolStripStatusLabelUltimaAtualizacao.Text = string.Format("Atualizado às {0}", DateTime.Now.ToLongTimeString());
            //    toolStripStatusLabelTotalRegistros.Text = string.Format("Total de registros: {0}", valuesDTOList.Count);

            //    TxtCodigoCadastro.Focus();
            //    TxtCodigoCadastro.SelectAll();
            //}
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
            BtnExcluir.Enabled = valor;
            BtnNovo.Enabled = valor;
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

            this.TxtTurmaAtual.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTurmaAtual.ForeColor = System.Drawing.SystemColors.Window;
            
            this.TxtAlergia.BackColor = System.Drawing.SystemColors.Control;
            this.TxtAlergia.ForeColor = System.Drawing.SystemColors.Window;

            this.TxtRestrincaoAlimentar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.Window;

            this.TxtDeficienteAtipicos.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.Window;
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

        public object Clone()
        {
            throw new NotImplementedException();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private async void NovoRegistro()
        {
            ValuesDTO novoValueDTO = new ValuesDTO();
            novoValueDTO.Entity_id = "cupCkNWP1eqyoXWPtcMmoM";
            novoValueDTO.NomeCrianca = "Marques Silva Fonseca Teste";
            novoValueDTO.DataNascimento = "02/01/1986";
            novoValueDTO.Mae = "Maria Silva Fonseca";
            novoValueDTO.Pai = "Roque Alves Fonseeca";
            novoValueDTO.OutroResponsavel = "";
            novoValueDTO.SelecioneATurma = "BRANCO/ROSA (0 A 11 M)";
            novoValueDTO.Telefone = "6399208-2269";
            novoValueDTO.EnderecoEmail = "marquesfonseca@gmail.com";
            novoValueDTO.Alergia = "SIM";
            novoValueDTO.SeAlergiaSimPreenchaAqui = "Intolerância a lactose";
            novoValueDTO.RestrincaoAlimentar = "SIM";
            novoValueDTO.SeRestrincaoAlimentarSimDescreva = "Não pode beber leite";
            novoValueDTO.AlgumaDeficienciaOuSituacaoAtipica = "NÃO";
            novoValueDTO.SeAlgumaDeficienciaDescrevaOsDetalhes = "-";
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
    }
}
