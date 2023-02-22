using Mapster;
using System;
using Trilhar.Entidades;

namespace Trilhar.Mapeamento
{
    public class ValuesMapeamento
    {
        public static void ValuesToMapeamento()
        {
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
        }
    }
}
