using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilhar.Forms
{
    public class Record
    {        
        public string id { get; set; }
        public string app_id { get; set; }
        public string entity_id { get; set; }
        public Values values { get; set; }
        public RelValues rel_values { get; set; }
        public SubformValues subform_values { get; set; }
        public bool approved { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string added_by { get; set; }
        public string user_ids { get; set; }
    }

    public class RelValues
    {
        [JsonProperty("c-xfGFlCnhzyk1W6pdKmow")]
        public List<string> cxfGFlCnhzyk1W6pdKmow { get; set; }
        public List<string> c9WQVdTCjjW6NcSaqPW7HL { get; set; }
        public List<string> cyW4r8W7DhW6ZcS8kjW6fy { get; set; }
        public List<string> bIl2VcHSjlc4ohW7pcV1CY { get; set; }
        public List<string> bDWQ1zleTdyRNdJwtdVmkx { get; set; }
        public List<string> dcGZGaW7PcG4obW7jJWOXy { get; set; }
        public List<string> cVF8kHn0TcT7KoWQicW41V { get; set; }
        public List<string> dcTx07W7jdSioSj1JdL8kD { get; set; }
    }

    public class Root
    {
        public List<Record> records { get; set; }
    }

    public class SubformValues
    {
    }

    public class Values
    {
        public string dcPfSQWPrdP4o2ccRdLNKz { get; set; }
        public string cluCkFshndGzatxtRcKSoa { get; set; }
        public string axdSotECjbuzdcLGtdHfTI { get; set; }
        public string dcRCkpW59gl4k4cCojWPO1 { get; set; }
        public string cRWPtcLSjijORdRCo5WRnR { get; set; }
        public string crWO5aWQTcMOk0W4hcRHOo { get; set; }
        public string dcJmoAW5vdHBKBsCkGvh4k { get; set; }
        public string bWWQqIfuLpW43dMtRcG8oN { get; set; }
        public string bsWOS1bwPegikrWQ3cGSob { get; set; }
        public string cdo8kfWODhW4GCW6LwjmoG { get; set; }

        [JsonProperty("c-xfGFlCnhzyk1W6pdKmow")]
        public string cxfGFlCnhzyk1W6pdKmow { get; set; }

        [JsonProperty("c-xfGFlCnhzyk1W6pdKmow_original")]
        public string cxfGFlCnhzyk1W6pdKmow_original { get; set; }
        public string bNF2CMbHPldQ9zWQRdJx1w { get; set; }
        public string cVF8kHn0TcT7KoWQicW41V { get; set; }
        public string cVF8kHn0TcT7KoWQicW41V_original { get; set; }
        public string dcJSoRWPndIOkjqSkTbCk5 { get; set; }
        public string bAfHJcV8njWOGiWQztd8ks { get; set; }
        public string bDWQ1zleTdyRNdJwtdVmkx { get; set; }
        public string bDWQ1zleTdyRNdJwtdVmkx_original { get; set; }
        public string dcGZGaW7PcG4obW7jJWOXy { get; set; }
        public object dcGZGaW7PcG4obW7jJWOXy_original { get; set; }
        public string bIl2VcHSjlc4ohW7pcV1CY { get; set; }
        public string bIl2VcHSjlc4ohW7pcV1CY_original { get; set; }
        public string ddMCowu8nnkykKW65JESoi { get; set; }
        public string dcTx07W7jdSioSj1JdL8kD { get; set; }
        public string dcTx07W7jdSioSj1JdL8kD_original { get; set; }
        public string c9WQVdTCjjW6NcSaqPW7HL { get; set; }
        public string c9WQVdTCjjW6NcSaqPW7HL_original { get; set; }
        public string cyW4r8W7DhW6ZcS8kjW6fy { get; set; }
        public string cyW4r8W7DhW6ZcS8kjW6fy_original { get; set; }
        public string ddIN7cMCneAA9hW7OeAa0i { get; set; }
        public string c1dmoHWPHcpioPW43cN8oA { get; set; }
        public string cAq1TbESnlW6z7tJlcKCk9 { get; set; }
        public string dcT8kfWQfcGOkifJXub0ir { get; set; }
    }

    public class ValuesDTO
    {
        public string CodigoCadastro { get; set; } //dcPfSQWPrdP4o2ccRdLNKz
        public string NomeCrianca { get; set; } //cluCkFshndGzatxtRcKSoa
        public string DataNascimento { get; set; } //axdSotECjbuzdcLGtdHfTI
        public string Mae { get; set; } //dcJSoRWPndIOkjqSkTbCk5
        public string Pai { get; set; } //bAfHJcV8njWOGiWQztd8ks
        public string OutroResponsavel { get; set; } //dcRCkpW59gl4k4cCojWPO1
        public string SelecioneATurma { get; set; } //cRWPtcLSjijORdRCo5WRnR
        public string Telefone { get; set; } //crWO5aWQTcMOk0W4hcRHOo
        public string EnderecoEmail { get; set; } //dcJmoAW5vdHBKBsCkGvh4k
        public string Alergia { get; set; } //bWWQqIfuLpW43dMtRcG8oN
        public string SeAlergiaSimPreenchaAqui { get; set; } //ddIN7cMCneAA9hW7OeAa0i
        public string RestrincaoAlimentar { get; set; } //bsWOS1bwPegikrWQ3cGSob
        public string SeRestrincaoAlimentarSimDescreva { get; set; } //ddMCowu8nnkykKW65JESoi
        public string AlgumaDeficienciaOuSituacaoAtipica { get; set; } //bNF2CMbHPldQ9zWQRdJx1w
        public string SeAlgumaDeficienciaDescrevaOsDetalhes { get; set; } //c1dmoHWPHcpioPW43cN8oA
        public string Batizado { get; set; } //cdo8kfWODhW4GCW6LwjmoG
        public string DataBatismo { get; set; } //cAq1TbESnlW6z7tJlcKCk9
        public string IgrejaBatizou { get; set; } //dcT8kfWQfcGOkifJXub0ir
        [JsonProperty("c-xfGFlCnhzyk1W6pdKmow")]
        public string ChamadaAzul_9_10Anos { get; set; } //cxfGFlCnhzyk1W6pdKmow
        public string ChamadaAzulRoyal_11_12Anos { get; set; } //c9WQVdTCjjW6NcSaqPW7HL
        public string ChamadaBranco_0_11Me29D { get; set; } //cyW4r8W7DhW6ZcS8kjW6fy
        public string ChamadaLaranja_3_4Anos { get; set; } //bIl2VcHSjlc4ohW7pcV1CY
        public string ChamadaLilas_1Ano { get; set; } //bDWQ1zleTdyRNdJwtdVmkx
        public string ChamadaLilas_2_Anos { get; set; } //dcGZGaW7PcG4obW7jJWOXy
        public string ChamadaVerde_7_8Anos { get; set; }//cVF8kHn0TcT7KoWQicW41V
        public string ChamadaVermelho_5_6Anos { get; set; } //dcTx07W7jdSioSj1JdL8kD
    }
}
