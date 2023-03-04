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
        /// <summary>
        /// Retorna todos os registros da integração QuintaDB.
        /// </summary>
        /// <returns>Lista de Records</returns>
        public async Task<List<Record>> RetornarListaAsync()
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return await IntegracaoQuintaBDTrilharService.RetornarListaAsync();
        }

        /// <summary>
        /// Inserir novo Registro na integração QuintaDB
        /// </summary>
        /// <typeparam name="T">Insira a Entidade ValueDTO.</typeparam>
        /// <param name="data">Insira a entidade ValueDTO preenchida.</param>
        /// <returns>Retona o Records.</returns>
        public async Task<Record> InserirAsync<T>(ValuesDTO data)
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return await IntegracaoQuintaBDTrilharService.InserirAsync<T>(data);
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
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return await IntegracaoQuintaBDTrilharService.AlterarAsync<T>(id, data);
        }

        /// <summary>
        /// Remove o registro na integração QuintaDB.
        /// </summary>
        /// <param name="id">Informe o valor do campo id do regigisto.</param>
        /// <returns>Retorna o True para sucesso!, False para erro.</returns>
        public Task<bool> DeletarAsync(string id)
        {
            Trilhar.Integracao.QuintaBDTrilharService IntegracaoQuintaBDTrilharService = new Integracao.QuintaBDTrilharService();
            return IntegracaoQuintaBDTrilharService.DeletarAsync(id);
        }
    }
}
