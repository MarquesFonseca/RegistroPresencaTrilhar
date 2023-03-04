using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trilhar.Entidades;

namespace Trilhar.Controle.Interface
{
    public interface IIntegracaoQuintaDBTrilharService
    {
        Task<List<Record>> RetornarListaAsync();

        Task<Record> InserirAsync<T>(ValuesDTO data);

        Task<Record> AlterarAsync<T>(string id, ValuesDTO data);

        Task<bool> DeletarAsync(string id);
    }
}
