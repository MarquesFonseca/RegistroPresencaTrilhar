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

        //public async Task<List<ValuesDTO>> GetListAsync()
        //{
        //    List<ValuesDTO> RetornoValuesDTOList = new List<ValuesDTO>();

        //    //var response = await client.GetAsync(url);
        //    //var content = await response.Content.ReadAsStringAsync();
        //    //return JsonConvert.DeserializeObject<List<T>>(content);

        //    //string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
        //    string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&fetch_all=true&page=";

        //    int i = 0;
        //    while (true)
        //    {
        //        if (!Internet.CheckForInternetConnection())
        //        {
        //            MessageBox.Show("Sem conexão com internet no momento!");
        //            break;
        //        }
        //        string novoI = (i + 1).ToString();
        //        string novoURI = URI + novoI;
        //        using (HttpClient client = new HttpClient())
        //        {
        //            using (var response = await client.GetAsync(novoURI))
        //            {
        //                if (response.IsSuccessStatusCode)
        //                {
        //                    var CadastroTrilharJsonString = await response.Content.ReadAsStringAsync();
        //                    var JsonFormatado = JToken.Parse(CadastroTrilharJsonString).ToString(Formatting.Indented);
        //                    CadastroTrilhar myDeserializedCadastroTrilhar = JsonConvert.DeserializeObject<CadastroTrilhar>(JsonFormatado);

        //                    if (myDeserializedCadastroTrilhar.records.Count == 0)
        //                    {
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        foreach (Record record in myDeserializedCadastroTrilhar.records)
        //                        {
        //                            Trilhar.Entidades.ValuesDTO valuesDTO = record.values.Adapt<Trilhar.Entidades.ValuesDTO>();

        //                            RetornoValuesDTOList.Add(valuesDTO);
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Não foi possível obter os registros : " + response.StatusCode);
        //                }
        //            }
        //        }
        //        i++;
        //    }

        //    if (RetornoValuesDTOList != null && RetornoValuesDTOList.Count >= 0)
        //    {
        //        return RetornoValuesDTOList;

        //    }
        //    else
        //    {
        //        return new List<ValuesDTO>();
        //    }
        //}

        public List<ValuesDTO> GetListValues(List<Record> recordsList)
        {
            List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();
            foreach (Record record in recordsList)
            {
                ValuesDTO valuesDTO = record.values.Adapt<ValuesDTO>();
                valuesDTOList.Add(valuesDTO);
            }
            return valuesDTOList;
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

        public async Task<ValuesDTO> PostAsync<T>(ValuesDTO data)
        {
            ValuesDTO Retono = new ValuesDTO();
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
                        Trilhar.Entidades.Values value = JsonConvert.DeserializeObject<Response>(JsonFormatado).record.values;
                        if (value != null)
                        {
                            Retono = value.Adapt<Values, ValuesDTO>();
                        }
                    }
                }
            }

            return Retono;
        }

        public async Task<ValuesDTO> PutAsync<T>(ValuesDTO data)
        {
            ValuesDTO Retono = new ValuesDTO();
            string url = "";

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
                        Trilhar.Entidades.Values value = JsonConvert.DeserializeObject<Response>(JsonFormatado).record.values;
                        if (value != null)
                        {
                            Retono = value.Adapt<Values, ValuesDTO>();
                        }
                    }
                }
            }

            return Retono;
        }

        public async Task<bool> DeleteAsync()
        {
            string url = "";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);
                return response.IsSuccessStatusCode;
            }
        }
    }
}
