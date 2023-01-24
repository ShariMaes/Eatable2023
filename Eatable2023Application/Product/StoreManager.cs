using Eatable2023Dto.General;
using Eatable2023Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable2023Application.Product
{
    public class StoreManager: IStoreManager
    {
        public IEnumerable<StoreDto> GetStoreList()
        {
            var list = new List<StoreDto>();

            list.Add(
                new StoreDto
                {
                    StoreId = new Guid(),
                    StoreIdentifier = "",
                    StoreName = "testwinkel",
                    StoreType = "Fysical",
                    OpeningHours = "Alle dagen",
                    Address = new AddressDto
                    {
                        AddressId = new Guid(),
                        Street = "Ambroos",
                        HouseNumber = 130,
                        Postalcode = 12134,
                        City = "Zemst"
                    }
                }
                    );
                list.Add(
                new StoreDto
                {
                    StoreId = new Guid(),
                    StoreIdentifier = "",
                    StoreName = "testwinkel2",
                    StoreType = "Fysical",
                    OpeningHours = "Alle dagen",
                    Address = new AddressDto
                    {
                        AddressId = new Guid(),
                        Street = "Vinkenlaan",
                        HouseNumber = 13,
                        Postalcode = 12135,
                        City = "Eppegem"
                    }
                }) ;

            //_mapper.Map();

            return list;
        }
    }
}
