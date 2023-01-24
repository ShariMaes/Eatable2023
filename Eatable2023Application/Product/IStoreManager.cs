using Eatable2023Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable2023Application.Product
{
    public interface IStoreManager
    {
        IEnumerable<StoreDto> GetStoreList();

    }
}
