using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trilhar.Uteis;
using Trilhar.Entidades;
using Mapster;
using System.Linq;
using Trilhar.Mapeamento;

namespace Trilhar.Integracao
{
    public class QuintaBDTrilhar : IQuintaBDTrilhar, IDisposable
    {
        private static readonly HttpClient client = new HttpClient();
        List<Trilhar.Entidades.ValuesDTO> valuesDTOList = new List<Trilhar.Entidades.ValuesDTO>();

        public QuintaBDTrilhar()
        {
            ValuesMapeamento.ValuesToMapeamento();
        }
        
        public async Task<List<ValuesDTO>> GetListAsync()
        {
            //var response = await client.GetAsync(url);
            //var content = await response.Content.ReadAsStringAsync();
            //return JsonConvert.DeserializeObject<List<T>>(content);

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
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(novoURI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var CadastroTrilharJsonString = await response.Content.ReadAsStringAsync();
                            CadastroTrilhar myDeserializedCadastroTrilhar = JsonConvert.DeserializeObject<CadastroTrilhar>(CadastroTrilharJsonString);

                            if (myDeserializedCadastroTrilhar.records.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                foreach (Record record in myDeserializedCadastroTrilhar.records)
                                {
                                    Trilhar.Entidades.ValuesDTO valuesDTO = record.values.Adapt<Trilhar.Entidades.ValuesDTO>();

                                    valuesDTOList.Add(valuesDTO);
                                }
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

            if (valuesDTOList != null && valuesDTOList.Count >= 0)
            {
                return valuesDTOList;

            }
            else
            {
                return new List<ValuesDTO>();
            }
        }

        public async Task<T> PostAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> PutAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<bool> DeleteAsync(string url)
        {
            var response = await client.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }

        public void Dispose()
        {
            valuesDTOList.Clear();
        }
    }
}
