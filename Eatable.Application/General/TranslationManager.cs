using AutoMapper;
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
    public class TranslationManager: BaseManager, ITranslationManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TranslationManager(EatableContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<TranslationDto>> GetAllTranslations()
        {
            var list = await _context.Translation.ToListAsync();
            var mapped = _mapper.Map<List<TranslationDto>>(list);

            return mapped;
        }
    }
}
