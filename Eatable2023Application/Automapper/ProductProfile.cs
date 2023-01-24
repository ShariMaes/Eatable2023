using AutoMapper;
using Eatable2023Data.General;
using Eatable2023Data.Product;
using Eatable2023Dto.General;
using Eatable2023Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable2023Application.Automapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            //DTO to Data
            CreateMap<StoreDto, Store>();
            //CreateMap<ProductDto, Product>();
            CreateMap<AddressDto, Address>();


            //Data to DTO
            CreateMap<Store, StoreDto>();
            CreateMap<Address, AddressDto>();
        }
    }
}
