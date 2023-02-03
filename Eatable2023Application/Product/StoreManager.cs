using AutoMapper;
using Eatable.Data.Services;
using Eatable.Dto.Product;
using System;
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

        public StoreDto GetStoreById(Guid id)
        {
            var result = _productServices.GetStoreById(id);
            result.ContactInformation = _productServices.GetContactByObjectId(result.StoreId);
            var mapped = _mapper.Map<StoreDto>(result);

            return mapped;
        }

        public StoreDto GetStoreByIdentifier(string identifier)
        {
            var result = _productServices.GetStoreByIdentifier(identifier);
            result.ContactInformation = _productServices.GetContactByObjectId(result.StoreId);
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
