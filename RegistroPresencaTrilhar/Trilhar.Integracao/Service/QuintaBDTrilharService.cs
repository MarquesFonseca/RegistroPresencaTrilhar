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
    public class QuintaBDTrilharService : IQuintaBDTrilharService
    {
        public QuintaBDTrilharService()
        {
            Trilhar.Mapeamento.ValuesMapeamento.ValuesToValuesDTOMapeamento();
            Trilhar.Mapeamento.ValuesMapeamento.ValuesDTOToValuesMapeamento();
        }

        /// <summary>
        /// Retorna todos os registros da integração QuintaDB.
        /// </summary>
        /// <returns>Lista de Records</returns>
        public async Task<List<Record>> RetornarListaAsync()
        {
            List<Record> RetornoRecordList = new List<Record>();

            //string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
            string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&fetch_all=true&page=";

            int i = 0;
            while (true)
            {
                if (!InternetUteis.CheckForInternetConnection())
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

        /// <summary>
        /// Inserir novo Registro na integração QuintaDB
        /// </summary>
        /// <typeparam name="T">Insira a Entidade ValueDTO.</typeparam>
        /// <param name="data">Insira a entidade ValueDTO preenchida.</param>
        /// <returns>Retona o Records.</returns>
        public async Task<Record> InserirAsync<T>(ValuesDTO data)
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

        /// <summary>
        /// Altera o registro na integração QuintaDB.
        /// </summary>
        /// <typeparam name="T">Insira a Entidade ValueDTO.</typeparam>
        /// <param name="id">Informe o valor do campo id do regigisto.</param>
        /// <param name="data">Insira a entidade ValueDTO preenchida.</param>
        /// <returns>Retona o Records.</returns>
        public async Task<Record> AlterarAsync<T>(string id, ValuesDTO data)
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

        /// <summary>
        /// Remove o registro na integração QuintaDB.
        /// </summary>
        /// <param name="id">Informe o valor do campo id do regigisto.</param>
        /// <returns>Retorna o True para sucesso!, False para erro.</returns>
        public async Task<bool> DeletarAsync(string id)
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
