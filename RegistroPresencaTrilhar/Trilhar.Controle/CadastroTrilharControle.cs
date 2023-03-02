using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Trilhar.Uteis;
using Trilhar.Entidades;

namespace Trilhar.Controle
{
    public class CadastroTrilharControle
    {
        public static List<ValuesDTO> GetListValues(List<Record> recordsList)
        {
            List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();
            foreach (Record record in recordsList)
            {
                ValuesDTO valuesDTO = record.values.Adapt<ValuesDTO>();

                valuesDTO.SelecioneATurma = RetornaDescricaoCmbTurmaAtual(valuesDTO.SelecioneATurma);
                valuesDTOList.Add(valuesDTO);
            }
            return valuesDTOList;
        }

        public static string RetornaDescricaoCmbTurmaAtual(string Valor)
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
    }
}
