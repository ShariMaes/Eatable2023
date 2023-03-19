using Eatable.Data.Store;
using Eatable.Dto.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.StoreManager
{
    public interface IStoreManager
    {
        Task<StoreDto> AddStore(StoreDto storedto);
        Task<StoreDto> GetStoreById(Guid id);
        Task<StoreDto> GetStoreByIdentifier(string identifier);
        Task<List<StoreDto>> GetStoreList();

    }
}
