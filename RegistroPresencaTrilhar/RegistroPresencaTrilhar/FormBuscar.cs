using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPresencaTrilhar
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
            BuscarPeloPai
        }

        public FormBuscar(List<ValuesDTO> valuesDTOList, TipoBusca tipoBusca)
        {
            this.valuesDTOList = valuesDTOList;
            this.ItemSelecionado = new ValuesDTO();
            this.tipoBusca = tipoBusca;

            InitializeComponent();
            if (this.tipoBusca == TipoBusca.BuscarPeloNome)
            {
                this.Text = "Buscando criança pelo nome";
            }
            if (this.tipoBusca == TipoBusca.BuscarPelaMae)
            {
                this.Text = "Buscando criança pela mãe";
            }
            if (this.tipoBusca == TipoBusca.BuscarPeloPai)
            {
                this.Text = "Buscando criança pelo pai";
            }
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = this.valuesDTOList;
            valuesDTOBindingSource.DataSource = this.valuesDTOList;

            TxtCampoPesquisa.Focus();
            TxtCampoPesquisa.SelectAll();
        }

        private void TxtCampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (this.tipoBusca == TipoBusca.BuscarPeloNome)
            {
                valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => RemoveSpecialCharactersAndAccents(num.NomeCrianca.ToUpper()).Contains(RemoveSpecialCharactersAndAccents(TxtCampoPesquisa.Text.ToUpper())));
                valuesDTOBindingSource.ResetBindings(false);
            }
            if (this.tipoBusca == TipoBusca.BuscarPelaMae)
            {
                valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => RemoveSpecialCharactersAndAccents(num.Mae.ToUpper()).Contains(RemoveSpecialCharactersAndAccents(TxtCampoPesquisa.Text.ToUpper())));
                valuesDTOBindingSource.ResetBindings(false);
            }
            if (this.tipoBusca == TipoBusca.BuscarPeloPai)
            {
                valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => RemoveSpecialCharactersAndAccents(num.Pai.ToUpper()).Contains(RemoveSpecialCharactersAndAccents(TxtCampoPesquisa.Text.ToUpper())));
                valuesDTOBindingSource.ResetBindings(false);
            }
        }

        public static string RemoveSpecialCharactersAndAccents(string text)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var codigoSelecionado = dataGridView1.SelectedRows[0].Cells[0].FormattedValue;

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
            if(e.KeyData == Keys.Down)
            {
                valuesDTOBindingSource.MoveNext();
            }
            if (e.KeyData == Keys.Up)
            {
                valuesDTOBindingSource.MoveLast();
            }
        }
    }
}
