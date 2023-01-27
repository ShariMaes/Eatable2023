using AutoMapper;
using Eatable.Data.Services;
using Eatable.Dto.Product;
using System.Collections.Generic;

namespace Eatable.Application.Product
{
    public class StoreManager: IStoreManager
    {
        private readonly IProductService _productServices;
        private readonly IMapper _mapper;

        public StoreManager(IProductService service, IMapper mapper)
        {
            _productServices = service;
            _mapper = mapper;
        }

        public List<StoreDto> GetStoreList()
        {
            var list = _productServices.GetStoreList();
            var mapped = _mapper.Map<List<StoreDto>>(list);

            return mapped;
        }
    }
}
