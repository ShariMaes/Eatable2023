using AutoMapper;
using Eatable.Application.General;
using Eatable.Common.Enum;
using Eatable.Data.General;
using Eatable.Data.Store;
using Eatable.Dto.General;
using Eatable.Dto.Store;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.StoreManager
{
    public class StoreManager : BaseManager, IStoreManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IKeyIdentifierManager _keyIdentifierManager;

        public StoreManager(EatableContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, IKeyIdentifierManager keyIdentifierManager) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _keyIdentifierManager = keyIdentifierManager;
        }

        public async Task<StoreDto> AddStore(StoreDto storeDto)
        {
            var store = _mapper.Map<Store>(storeDto);
            if (store.StoreIdentifier.IsNullOrEmpty())
            {
                var keyIdentifer = await _keyIdentifierManager.GetNextKeyIdentifierByObjectCodeType(ObjectCodeType.Store);

                store.StoreIdentifier = keyIdentifer;
                store.StoreId = new Guid();

                _context.Add(store);
                _context.SaveChanges();
            }
            else
            {
                //Get + Update
                //await _context.SaveChangesAsync();
            }

            return GetStoreByIdentifier(store.StoreIdentifier).Result;
        }

        public async Task<StoreDto> GetStoreById(Guid id)
        {
            var store = await _context.Store
                .Include(s => s.ContactInformation)
                .Include(s => s.Address)
                .SingleAsync(s => s.StoreId.Equals(id));

            var mapped = _mapper.Map<StoreDto>(store);

            return mapped;
        }

        public async Task<StoreDto> GetStoreByIdentifier(string identifier)
        {
            var store = await _context.Store
                .Include(s => s.ContactInformation)
                .Include(s => s.Address)
                .SingleAsync(s => s.StoreIdentifier.Equals(identifier));

            var mapped = _mapper.Map<StoreDto>(store);

            return mapped;
        }

        public async Task<List<StoreDto>> GetStoreList()
        {
            var list = await _context.Store.ToListAsync();
            var mapped = _mapper.Map<List<StoreDto>>(list);

            return mapped;
        }

    }
}
