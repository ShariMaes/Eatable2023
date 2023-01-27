using AutoMapper;
using Eatable.Data.General;
using Eatable.Data.Product;
using Eatable.Dto.General;
using Eatable.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.Automapper
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
