using System.Collections.Generic;
using System.Threading.Tasks;
using Trilhar.Entidades;

namespace Trilhar.Integracao
{
    public interface IQuintaBDTrilharService
    {
        Task<List<Record>> RetornarListaAsync();

        Task<Record> InserirAsync<T>(ValuesDTO data);

        Task<Record> AlterarAsync<T>(string id, ValuesDTO data);
            
        Task<bool> DeletarAsync(string id);
    }
}
