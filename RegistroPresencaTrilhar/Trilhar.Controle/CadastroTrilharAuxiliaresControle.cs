using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Trilhar.Uteis;
using Trilhar.Entidades;
using Trilhar.Controle.Interface;
using System.Globalization;
using System.Reflection;

namespace Trilhar.Controle
{
    public class CadastroTrilharAuxiliaresControle
    {
        public static List<ValuesDTO> GetListValues(List<Record> recordsList)
        {
            List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();
            foreach (Record record in recordsList)
            {
                ValuesDTO valuesDTO = record.values.Adapt<ValuesDTO>();

                valuesDTO.SelecioneATurma = RetornaDescricaoPeloValorTurmaAtual(valuesDTO.SelecioneATurma);
                valuesDTOList.Add(valuesDTO);
            }
            return valuesDTOList;
        }

        public static string RetornaDescricaoPeloValorTurmaAtual(string strValor)
        {
            switch (strValor)
            {
                case "BRANCO/ROSA (0 A 11 M)": return "BRANCO/ROSA (0 A 11 M)";
                case "LILÁS (1 ANO)": return "LILÁS (1 ANO)";
                case "LILÁS (2 ANOS)": return "LILÁS (2 ANOS)";
                case "LARANJA": return "LARANJA 3-4 ANOS";
                case "VERMELHO": return "VERMELHO 5-6 ANOS";
                case "VERDE": return "VERDE 7-8 ANOS";
                case "AZUL (9-10 ANOS)": return "AZUL 9-10 ANOS";
                case "AZUL ROYAL (11-12 ANOS)": return "AZUL ROYAL 11-12 ANOS";
                default: return "";
            }
        }

        public static string RetornaValorPelaDescricaoTurmaAtual(string strDescricao)
        {
            if (strDescricao == "BRANCO/ROSA (0 A 11 M)") { return "BRANCO/ROSA (0 A 11 M)"; }
            if (strDescricao == "LILÁS (1 ANO)") { return "LILÁS (1 ANO)"; }
            if (strDescricao == "LILÁS (2 ANOS)") { return "LILÁS (2 ANOS)"; }
            if (strDescricao == "LARANJA 3-4 ANOS") { return "LARANJA"; }
            if (strDescricao == "VERMELHO 5-6 ANOS") { return "VERMELHO"; }
            if (strDescricao == "VERDE 7-8 ANOS") { return "VERDE"; }
            if (strDescricao == "AZUL 9-10 ANOS") { return "AZUL (9-10 ANOS)"; }
            if (strDescricao == "AZUL ROYAL 11-12 ANOS") { return "AZUL ROYAL (11-12 ANOS)"; }

            return "";
        }

        public static string RetonaSugestaoTurma(string dataNascimento)
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

        private static bool VerificaPeriodoTurma(string data, string limiteInferior, string limiteSuperior)
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

        public static List<ValuesDTO> RemoveCamposVazio(List<ValuesDTO> valuesDTOList)
        {
            foreach (ValuesDTO obj in valuesDTOList)
            {
                Type type = typeof(ValuesDTO);
                System.Reflection.PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (property.PropertyType.Name == "String")
                    {
                        var valorPropriedadeObjeto = property.GetValue(obj);
                        if (valorPropriedadeObjeto == null || valorPropriedadeObjeto.ToString() == string.Empty)
                        {
                            // Atribuímos um novo valor à propriedade usando reflexão
                            property.SetValue(obj, string.Empty);
                        }
                    }
                }
            }

            return valuesDTOList;
        }

    }
}
