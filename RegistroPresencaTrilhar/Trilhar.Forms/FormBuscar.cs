using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trilhar.Controle;
using Trilhar.Entidades;

namespace Trilhar.Forms
{
    public partial class FormBuscar : Form
    {
        private List<ValuesDTO> valuesDTOList;
        public ValuesDTO ItemSelecionado;
        private TipoBusca tipoBusca;
        public bool Cancelado = false;
        public bool Selecionado = false;

        public enum TipoBusca
        {
            BuscarPeloNome,
            BuscarPelaMae,
            BuscarPeloPai,
            BuscarPelaTurma
        }

        public FormBuscar(List<ValuesDTO> valuesDTOList, TipoBusca tipoBusca)
        {
            this.valuesDTOList = CadastroTrilharAuxiliaresControle.RemoveCamposVazio(valuesDTOList);
            this.ItemSelecionado = new ValuesDTO();
            this.tipoBusca = tipoBusca;

            InitializeComponent();
            
        }        

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            if (this.tipoBusca == TipoBusca.BuscarPeloNome)
            {
                //this.TxtCampoPesquisa.Size = new Size(1118, 35);
                this.Text = "Buscando criança pelo nome";
            }
            if (this.tipoBusca == TipoBusca.BuscarPelaMae)
            {
               // this.TxtCampoPesquisa.Size = new Size(1118, 35);
                this.Text = "Buscando criança pela mãe";
            }
            if (this.tipoBusca == TipoBusca.BuscarPeloPai)
            {
                //this.TxtCampoPesquisa.Size = new Size(1118, 35);
                this.Text = "Buscando criança pelo pai";
            }
            if (this.tipoBusca == TipoBusca.BuscarPelaTurma)
            {
                this.TxtCampoPesquisa.Size = new Size(566, 35);
                this.Text = "Buscando criança pela turma";
            }

            valuesDTOBindingSource.DataSource = this.valuesDTOList;

            TxtCampoPesquisa.Focus();
            TxtCampoPesquisa.SelectAll();
        }

        private void TxtCampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            //if (TxtCampoPesquisa.Text.Length <= 3) return;
            string TextoDigitado = RemoveSpecialCharactersAndAccents(TxtCampoPesquisa.Text.ToUpper());
            if (this.tipoBusca == TipoBusca.BuscarPeloNome)
            {
                valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => !string.IsNullOrEmpty(num.NomeCrianca) && RemoveSpecialCharactersAndAccents(num.NomeCrianca.ToUpper()).Contains(TextoDigitado));
                valuesDTOBindingSource.ResetBindings(false);
            }
            if (this.tipoBusca == TipoBusca.BuscarPelaMae)
            {
                valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => !string.IsNullOrEmpty(num.Mae) && RemoveSpecialCharactersAndAccents(num.Mae.ToUpper()).Contains(TextoDigitado));
                valuesDTOBindingSource.ResetBindings(false);
            }
            if (this.tipoBusca == TipoBusca.BuscarPeloPai)
            {
                valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => !string.IsNullOrEmpty(num.Pai) && RemoveSpecialCharactersAndAccents(num.Pai.ToUpper()).Contains(TextoDigitado));
                valuesDTOBindingSource.ResetBindings(false);
            }

            int quantidadeRegistros = valuesDTOBindingSource.Count == 1 && valuesDTOBindingSource.Position == 0 ? 0 : valuesDTOBindingSource.Count;
            groupBox1.Text = string.Format("Resultado da pesquisa: {0} encontrado(s)!", quantidadeRegistros);
        }

        public static string RemoveSpecialCharactersAndAccents(string text)
        {
            try
            {
                string normalizedString = text.Normalize(NormalizationForm.FormD);
                StringBuilder stringBuilder = new StringBuilder();

                foreach (char c in normalizedString)
                {
                    UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                    if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    {
                        stringBuilder.Append(c);
                    }
                }

                string result = stringBuilder.ToString().Normalize(NormalizationForm.FormC);
                result = Regex.Replace(result, @"[^\w\s]", string.Empty, RegexOptions.None);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var codigoSelecionado = dataGridView1.SelectedRows[0].Cells[0].FormattedValue;
                if (string.IsNullOrEmpty(codigoSelecionado.ToString())) return;

                var itemAtual = valuesDTOList.Where(num => num.CodigoCadastro == codigoSelecionado.ToString()).FirstOrDefault();

                ItemSelecionado = (ValuesDTO)itemAtual;
                Selecionado = true;

                this.Close();
            }
        }

        private void TxtCampoPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void FormBuscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Selecionado) return;
            Cancelado = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(null, null);
        }

        private void FormBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                valuesDTOBindingSource.Position = valuesDTOBindingSource.Position + 1;
            }
            if (e.KeyData == Keys.Up)
            {
                valuesDTOBindingSource.Position = valuesDTOBindingSource.Position - 1;
            }
            if (e.KeyData == Keys.Escape)
            {
                TxtCampoPesquisa.Text = "";
            }
        }

        private void TxtCampoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                dataGridView1_DoubleClick(null, null);
            }
            if (e.KeyData == Keys.Down)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyData == Keys.Up)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyData == Keys.Escape)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
