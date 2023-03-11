using Eatable.Data.General;
using Eatable.Data.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eatable.Data.Services
{
    public interface IProductService: IDBServices
    {
        List<Store> GetStoreList();

        Task<Store> GetStoreById(Guid id);

        Task<Store> GetStoreByIdentifier(string identifier);

        Task<List<ContactInformation>> GetContactByObjectId(Guid id);
    }
}
