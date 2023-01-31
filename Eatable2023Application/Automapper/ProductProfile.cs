using AutoMapper;
using Eatable.Data.General;
using Eatable.Data.Product;
using Eatable.Dto.General;
using Eatable.Dto.Product;

namespace Eatable.Application.Automapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            //DTO to Data
            CreateMap<StoreDto, Store>();
            CreateMap<AddressDto, Address>();
            CreateMap<ContactInformationDto, ContactInformation>();


            //Data to DTO
            CreateMap<Store, StoreDto>();
            CreateMap<Address, AddressDto>();
            CreateMap<ContactInformation, ContactInformationDto>();
        }
    }
}
