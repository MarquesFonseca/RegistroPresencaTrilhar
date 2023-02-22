using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Mapster;
using Trilhar.Entidades;

namespace Trilhar.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            label1.Text = "Iniciou...";

            string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        //dgvDados.DataSource = JsonConvert.DeserializeObject<Produto[]>(ProdutoJsonString).ToList();
                        CadastroTrilhar myDeserializedClass = JsonConvert.DeserializeObject<CadastroTrilhar>(ProdutoJsonString);
                        //List<Root> people = JsonConvert.DeserializeObject<List<Root>>(ProdutoJsonString).ToList();
                        //dataGridView1.DataSource = null;
                        //dataGridView1.DataSource = myDeserializedClass.records;


                        List<ValuesDTO> valuesDTOList = new List<ValuesDTO>();
                        TypeAdapterConfig<Values, ValuesDTO>.NewConfig()
                                                        .Map(dest => dest.CodigoCadastro, src => src.dcPfSQWPrdP4o2ccRdLNKz)
                                                        .Map(dest => dest.NomeCrianca, src => src.cluCkFshndGzatxtRcKSoa)
                                                        .Map(dest => dest.DataNascimento, src => src.axdSotECjbuzdcLGtdHfTI)
                                                        .Map(dest => dest.Mae, src => src.dcJSoRWPndIOkjqSkTbCk5)
                                                        .Map(dest => dest.Pai, src => src.bAfHJcV8njWOGiWQztd8ks)
                                                        .Map(dest => dest.OutroResponsavel, src => src.dcRCkpW59gl4k4cCojWPO1)
                                                        .Map(dest => dest.SelecioneATurma, src => src.cRWPtcLSjijORdRCo5WRnR)
                                                        .Map(dest => dest.Telefone, src => src.crWO5aWQTcMOk0W4hcRHOo)
                                                        .Map(dest => dest.EnderecoEmail, src => src.dcJmoAW5vdHBKBsCkGvh4k)
                                                        .Map(dest => dest.Alergia, src => src.bWWQqIfuLpW43dMtRcG8oN)
                                                        .Map(dest => dest.SeAlergiaSimPreenchaAqui, src => src.ddIN7cMCneAA9hW7OeAa0i)
                                                        .Map(dest => dest.RestrincaoAlimentar, src => src.bsWOS1bwPegikrWQ3cGSob)
                                                        .Map(dest => dest.SeRestrincaoAlimentarSimDescreva, src => src.ddMCowu8nnkykKW65JESoi)
                                                        .Map(dest => dest.AlgumaDeficienciaOuSituacaoAtipica, src => src.bNF2CMbHPldQ9zWQRdJx1w)
                                                        .Map(dest => dest.SeAlgumaDeficienciaDescrevaOsDetalhes, src => src.c1dmoHWPHcpioPW43cN8oA)
                                                        .Map(dest => dest.Batizado, src => src.cdo8kfWODhW4GCW6LwjmoG)
                                                        .Map(dest => dest.DataBatismo, src => src.cAq1TbESnlW6z7tJlcKCk9)
                                                        .Map(dest => dest.IgrejaBatizou, src => src.dcT8kfWQfcGOkifJXub0ir)
                                                        .Map(dest => dest.ChamadaAzul_9_10Anos, src => src.cxfGFlCnhzyk1W6pdKmow)
                                                        .Map(dest => dest.ChamadaAzulRoyal_11_12Anos, src => src.c9WQVdTCjjW6NcSaqPW7HL)
                                                        .Map(dest => dest.ChamadaBranco_0_11Me29D, src => src.cyW4r8W7DhW6ZcS8kjW6fy)
                                                        .Map(dest => dest.ChamadaLaranja_3_4Anos, src => src.bIl2VcHSjlc4ohW7pcV1CY)
                                                        .Map(dest => dest.ChamadaLilas_1Ano, src => src.bDWQ1zleTdyRNdJwtdVmkx)
                                                        .Map(dest => dest.ChamadaLilas_2_Anos, src => src.dcGZGaW7PcG4obW7jJWOXy)
                                                        .Map(dest => dest.ChamadaVerde_7_8Anos, src => src.cVF8kHn0TcT7KoWQicW41V)
                                                        .Map(dest => dest.ChamadaVermelho_5_6Anos, src => src.dcTx07W7jdSioSj1JdL8kD);
                        
                        foreach (Record record in myDeserializedClass.records)
                        {


                            var valuesDTO = record.values.Adapt<ValuesDTO>();
                            valuesDTOList.Add(valuesDTO);
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = valuesDTOList;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
            label1.Text = "terminou...";
        }

        private async void GetAllProdutos()
        {
            string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/dtypes/entity/cupCkNWP1eqyoXWPtcMmoM.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE&amp;fetch_all=true&amp;page=11";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        //dgvDados.DataSource = JsonConvert.DeserializeObject<Produto[]>(ProdutoJsonString).ToList();
                        CadastroTrilhar myDeserializedClass = JsonConvert.DeserializeObject<CadastroTrilhar>(ProdutoJsonString);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetCampos()
        {
            string URI = "https://quintadb.com/apps/aGgLbrWO9cPP88W4WXkf55/entities/cupCkNWP1eqyoXWPtcMmoM/properties.json?rest_api_key=blwCkVWPnbdiJcSh44d8oE";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        Campos myDeserializedClass = JsonConvert.DeserializeObject<Campos>(ProdutoJsonString);

                        //Dictionary<string, string> dicionarioCampos = new Dictionary<string, string>();
                        //foreach (Field item in myDeserializedClass.fields)
                        //{
                        //    dicionarioCampos.Add(item.id, item.name);
                        //}
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = myDeserializedClass.fields;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
