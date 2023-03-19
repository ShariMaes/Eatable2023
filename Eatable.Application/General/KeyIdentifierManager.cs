using AutoMapper;
using Eatable.Application.StoreManager;
using Eatable.Common.Enum;
using Eatable.Dto.General;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.General
{
    public class KeyIdentifierManager : BaseManager, IKeyIdentifierManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public KeyIdentifierManager(EatableContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> GetNextKeyIdentifierByObjectCodeType(ObjectCodeType objectCodeType)
        {
            var keyIdentifierFromDb =  _context.KeyIdentifier.FromSqlInterpolated($"GetNextKeyIdentifierByObjectCodeType {objectCodeType}").AsEnumerable().FirstOrDefault();
            var indicator = GetIdentifierIndicatorByObjectCodeType(objectCodeType);
            var newIdentifier = indicator + _mapper.Map<KeyIdentifierDto>(keyIdentifierFromDb).Identifier.ToString().PadLeft(5, '0');
            return newIdentifier;
        }

        private string GetIdentifierIndicatorByObjectCodeType(ObjectCodeType objectCodeType)
        {
            var indicator = "";
            switch (objectCodeType)
            {
                case ObjectCodeType.Store:
                    indicator = "S";
                    break;
                case ObjectCodeType.User:
                    indicator = "U";
                    break;
                case ObjectCodeType.Product:
                    indicator = "P";
                    break;
            }
            return indicator;
        }
    }
}
