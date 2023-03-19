using Eatable.Common.Enum;
using Eatable.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.General
{
    public interface IKeyIdentifierManager
    {
        Task<string> GetNextKeyIdentifierByObjectCodeType(ObjectCodeType objectCodeType);
    }
}
