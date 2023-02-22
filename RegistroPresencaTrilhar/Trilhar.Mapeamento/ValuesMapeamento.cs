using Mapster;
using System;
using Trilhar.Entidades;

namespace Trilhar.Mapeamento
{
    public class ValuesMapeamento
    {
        /// <summary>
        /// SRC origem: Value
        /// Dest      : ValueDTO
        /// </summary>
        public static void ValuesToValuesDTOMapeamento()
        {
            TypeAdapterConfig<Values, ValuesDTO>.NewConfig()
                .Map(dest => dest.Entity_id, src => src.entity_id)
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
        }

        /// <summary>
        /// SRC origem: ValueDTO
        /// Dest      : Value
        /// </summary>
        public static void ValuesDTOToValuesMapeamento()
        {
            TypeAdapterConfig<ValuesDTO, Values>.NewConfig()
                .Map(dest => dest.entity_id, src => src.Entity_id)
                .Map(dest => dest.dcPfSQWPrdP4o2ccRdLNKz, src => src.CodigoCadastro)
                .Map(dest => dest.cluCkFshndGzatxtRcKSoa, src => src.NomeCrianca)
                .Map(dest => dest.axdSotECjbuzdcLGtdHfTI, src => src.DataNascimento)
                .Map(dest => dest.dcJSoRWPndIOkjqSkTbCk5, src => src.Mae)
                .Map(dest => dest.bAfHJcV8njWOGiWQztd8ks, src => src.Pai)
                .Map(dest => dest.dcRCkpW59gl4k4cCojWPO1, src => src.OutroResponsavel)
                .Map(dest => dest.cRWPtcLSjijORdRCo5WRnR, src => src.SelecioneATurma)
                .Map(dest => dest.crWO5aWQTcMOk0W4hcRHOo, src => src.Telefone)
                .Map(dest => dest.dcJmoAW5vdHBKBsCkGvh4k, src => src.EnderecoEmail)
                .Map(dest => dest.bWWQqIfuLpW43dMtRcG8oN, src => src.Alergia)
                .Map(dest => dest.ddIN7cMCneAA9hW7OeAa0i, src => src.SeAlergiaSimPreenchaAqui)
                .Map(dest => dest.bsWOS1bwPegikrWQ3cGSob, src => src.RestrincaoAlimentar)
                .Map(dest => dest.ddMCowu8nnkykKW65JESoi, src => src.SeRestrincaoAlimentarSimDescreva)
                .Map(dest => dest.bNF2CMbHPldQ9zWQRdJx1w, src => src.AlgumaDeficienciaOuSituacaoAtipica)
                .Map(dest => dest.c1dmoHWPHcpioPW43cN8oA, src => src.SeAlgumaDeficienciaDescrevaOsDetalhes)
                .Map(dest => dest.cdo8kfWODhW4GCW6LwjmoG, src => src.Batizado)
                .Map(dest => dest.cAq1TbESnlW6z7tJlcKCk9, src => src.DataBatismo)
                .Map(dest => dest.dcT8kfWQfcGOkifJXub0ir, src => src.IgrejaBatizou)
                .Map(dest => dest.cxfGFlCnhzyk1W6pdKmow, src => src.ChamadaAzul_9_10Anos)
                .Map(dest => dest.c9WQVdTCjjW6NcSaqPW7HL, src => src.ChamadaAzulRoyal_11_12Anos)
                .Map(dest => dest.cyW4r8W7DhW6ZcS8kjW6fy, src => src.ChamadaBranco_0_11Me29D)
                .Map(dest => dest.bIl2VcHSjlc4ohW7pcV1CY, src => src.ChamadaLaranja_3_4Anos)
                .Map(dest => dest.bDWQ1zleTdyRNdJwtdVmkx, src => src.ChamadaLilas_1Ano)
                .Map(dest => dest.dcGZGaW7PcG4obW7jJWOXy, src => src.ChamadaLilas_2_Anos)
                .Map(dest => dest.cVF8kHn0TcT7KoWQicW41V, src => src.ChamadaVerde_7_8Anos)
                .Map(dest => dest.dcTx07W7jdSioSj1JdL8kD, src => src.ChamadaVermelho_5_6Anos);
        }
    }
}
