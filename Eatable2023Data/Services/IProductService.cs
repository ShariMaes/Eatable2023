using Eatable.Data.Product;
using System.Collections.Generic;

namespace Eatable.Data.Services
{
    public interface IProductService: IDBServices
    {
        List<Store> GetStoreList();
    }
}
