using System.Collections.Generic;
using System.Threading.Tasks;
using Trilhar.Entidades;

namespace Trilhar.Integracao
{
    internal interface IQuintaBDTrilhar
    {        
        Task<List<ValuesDTO>> GetListAsync();

        Task<ValuesDTO> PostAsync<ValuesDTO>(ValuesDTO data);

        Task<T> PutAsync<T>(string url, T data);

        Task<bool> DeleteAsync(string url);
    }
}
