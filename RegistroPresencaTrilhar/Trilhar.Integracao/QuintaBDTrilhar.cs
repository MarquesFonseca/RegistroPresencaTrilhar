using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mapster;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trilhar.Uteis;
using Trilhar.Entidades;

namespace Trilhar.Integracao
{
    public class QuintaBDTrilhar : IQuintaBDTrilhar
    {
        public QuintaBDTrilhar()
        {
            Trilhar.Mapeamento.ValuesMapeamento.ValuesToValuesDTOMapeamento();
            Trilhar.Mapeamento.ValuesMapeamento.ValuesDTOToValuesMapeamento();
        }

        public List<ValuesDTO> GetListValues(List<Record> recordsList)
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

        private string RetornaDescricaoCmbTurmaAtual(string Valor)
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

        public async Task<List<Record>> GetListAsync()
        {
            List<Record> RetornoRecordList = new List<Record>();

            //string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
            string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&fetch_all=true&page=";

            int i = 0;
            while (true)
            {
                if (!Internet.CheckForInternetConnection())
                {
                    MessageBox.Show("Sem conexão com internet no momento!");
                    break;
                }
                string novoI = (i + 1).ToString();
                string novoURI = URI + novoI;
                using (HttpClient client = new HttpClient())
                {
                    using (var response = await client.GetAsync(novoURI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var CadastroTrilharJsonString = await response.Content.ReadAsStringAsync();
                            var JsonFormatado = JToken.Parse(CadastroTrilharJsonString).ToString(Formatting.Indented);
                            CadastroTrilhar myDeserializedCadastroTrilhar = JsonConvert.DeserializeObject<CadastroTrilhar>(JsonFormatado);

                            if (myDeserializedCadastroTrilhar.records.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                 RetornoRecordList.AddRange(myDeserializedCadastroTrilhar.records);                                
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

            if (RetornoRecordList != null && RetornoRecordList.Count >= 0)
            {
                return RetornoRecordList;

            }
            else
            {
                return new List<Record>();
            }
        }

        public async Task<Record> PostAsync<T>(ValuesDTO data)
        {
            Record Retono = new Record();
            string url = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE";

            Values dataValue = data.Adapt<ValuesDTO, Values>();

            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(new { values = dataValue });
                var contentjson = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PostAsync(url, contentjson))
                {
                    using (HttpContent content = response.Content)
                    {
                        string retorno = await content.ReadAsStringAsync();
                        var JsonFormatado = JToken.Parse(retorno).ToString(Formatting.Indented);
                        Record record = JsonConvert.DeserializeObject<Response>(JsonFormatado).record;
                        if (record != null)
                        {
                            Retono = record;
                        }
                    }
                }
            }

            return Retono;
        }

        public async Task<Record> PutAsync<T>(string id, ValuesDTO data)
        {
            Record Retono = new Record();
            string url = string.Format("https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/{0}.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE", id);

            Values dataValue = data.Adapt<ValuesDTO, Values>();

            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(new { values = dataValue });
                var contentjson = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PutAsync(url, contentjson))
                {
                    using (HttpContent content = response.Content)
                    {
                        string retorno = await content.ReadAsStringAsync();
                        var JsonFormatado = JToken.Parse(retorno).ToString(Formatting.Indented);
                        Record record = JsonConvert.DeserializeObject<Response>(JsonFormatado).record;
                        if (record != null)
                        {
                            Retono = record;
                        }
                    }
                }
            }

            return Retono;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            string url = string.Format("https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/{0}.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE", id);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);
                return response.IsSuccessStatusCode;
            }
        }
    }
}
