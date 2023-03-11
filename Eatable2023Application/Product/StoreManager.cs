using AutoMapper;
using Eatable.Data.Services;
using Eatable.Dto.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<StoreDto> GetStoreById(Guid id)
        {
            var result = await _productServices.GetStoreById(id);
            result.ContactInformation = await _productServices.GetContactByObjectId(result.StoreId);
            var mapped = _mapper.Map<StoreDto>(result);

            return mapped;
        }

        public async Task<StoreDto> GetStoreByIdentifier(string identifier)
        {
            var result = await _productServices.GetStoreByIdentifier(identifier);
            result.ContactInformation = await _productServices.GetContactByObjectId(result.StoreId);
            var mapped = _mapper.Map<StoreDto>(result);

            return mapped;
        }

        public List<StoreDto> GetStoreList()
        {
            var list = _productServices.GetStoreList();
            var mapped = _mapper.Map<List<StoreDto>>(list);

            return mapped;
        }
    }
}
