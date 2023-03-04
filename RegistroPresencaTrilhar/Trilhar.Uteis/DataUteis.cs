using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilhar.Uteis
{
    public static class DataUteis
    {
        public static bool VerificaSeDataValida(this DateTime data)
        {
            return VerificaSeDataValida(data.ToShortDateString());
        }

        public static bool VerificaSeDataValida(this string data)
        {
            //string data = "31/02/2022"; // Data inválida
            string formato = "dd/MM/yyyy";

            DateTime dataObj;
            bool dataValida = DateTime.TryParseExact(data, formato, null, System.Globalization.DateTimeStyles.None, out dataObj);

            if (dataValida)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string RetornaDescricaoDataCompleta(this DateTime date)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - date.Year;
            int month = today.Month - date.Month;
            int day = today.Day - date.Day;

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

        public static string PreencheIdadeFormatada(string dataNascimento)
        {
            if (dataNascimento == DateTime.Now.ToShortDateString()) return "";

            string idadeFormatada = "";
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNascimento, out dataConvertida))
            {
                idadeFormatada = DataUteis.RetornaDescricaoDataCompleta(new DateTime(Convert.ToDateTime(dataNascimento).Year, Convert.ToDateTime(dataNascimento).Month, Convert.ToDateTime(dataNascimento).Day));
                return idadeFormatada;
            }
            else
            {
                return "";
            }
        }
    }
}
