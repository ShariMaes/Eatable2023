using AutoMapper;
using Eatable.Data.Store;
using Eatable.Dto.Store;

namespace Eatable.Application.Automapper
{
    public class StoreProfile: Profile
    {
        public StoreProfile()
        {
            CreateMap<StoreDto, Store>();
            CreateMap<Store, StoreDto>();
        }
    }
}
