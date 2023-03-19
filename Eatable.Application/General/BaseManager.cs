using AutoMapper;
using Eatable.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.General
{
    public class BaseManager
    {
        protected readonly IMapper _mapper;
        protected readonly EatableContext _context;
        public BaseManager(EatableContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
