using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilhar.Uteis
{
    public static class VerificacaoData
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
    }
}
