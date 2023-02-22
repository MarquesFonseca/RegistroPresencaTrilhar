using System.Collections.Generic;
using System.Threading.Tasks;
using Trilhar.Entidades;

namespace Trilhar.Integracao
{
    internal interface IQuintaBDTrilhar
    {
        List<ValuesDTO> GetListValues(List<Record> recordsList);

        Task<List<Record>> GetListAsync();

        Task<ValuesDTO> PostAsync<T>(ValuesDTO data);

        Task<ValuesDTO> PutAsync<T>(ValuesDTO data);

        Task<bool> DeleteAsync();
    }
}
