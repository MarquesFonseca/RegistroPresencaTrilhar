using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Trilhar.Uteis;
using Trilhar.Entidades;
using Trilhar.Controle.Interface;

namespace Trilhar.Controle
{
    public class IntegracaoQuintaDBTrilharControle : IIntegracaoQuintaDBTrilharService
    {
        public async Task<Record> AlterarAsync<T>(string id, ValuesDTO data)
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return await IntegracaoQuintaBDTrilharService.AlterarAsync<T>(id, data);
        }

        public Task<bool> DeletarAsync(string id)
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return IntegracaoQuintaBDTrilharService.DeletarAsync(id);
        }

        public async Task<Record> InserirAsync<T>(ValuesDTO data)
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return await IntegracaoQuintaBDTrilharService.InserirAsync<T>(data);
        }

        public async Task<List<Record>> RetornarListaAsync()
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return await IntegracaoQuintaBDTrilharService.RetornarListaAsync();
        }
    }
}
