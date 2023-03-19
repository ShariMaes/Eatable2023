using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Importer.Importers
{
    public class BaseImporter
    {
        protected readonly IHttpContextAccessor _httpContextAccessor;
        public BaseImporter(IHttpContextAccessor httpContextAccessor) 
        {
            _httpContextAccessor = httpContextAccessor;
        }

    }
}
