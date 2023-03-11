using Eatable.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.Product
{
    public interface IStoreManager
    {
        List<StoreDto> GetStoreList();

        Task<StoreDto> GetStoreById(Guid id);

        Task<StoreDto> GetStoreByIdentifier(string identifier);

    }
}
