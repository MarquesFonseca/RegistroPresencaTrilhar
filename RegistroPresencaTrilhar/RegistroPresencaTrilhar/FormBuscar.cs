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

        public FormBuscar(List<ValuesDTO> valuesDTOList)
        {
            this.valuesDTOList = valuesDTOList;
            this.ItemSelecionado = new ValuesDTO();

            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = this.valuesDTOList;
            valuesDTOBindingSource.DataSource = this.valuesDTOList;

            TxtCampoPesquisa.Focus();
        }

        private void TxtCampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            valuesDTOBindingSource.DataSource = this.valuesDTOList.Where(num => RemoveSpecialCharactersAndAccents(num.NomeCrianca.ToUpper()).Contains(RemoveSpecialCharactersAndAccents(TxtCampoPesquisa.Text.ToUpper())));
            //valuesDTOBindingSource.Filter = string.Format("NomeCrianca = '{0}%'", TxtCampoPesquisa.Text);
            valuesDTOBindingSource.ResetBindings(false);
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



    }
}
