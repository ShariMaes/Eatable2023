using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Importer.Importers
{
    public interface IBaseImporter
    {
        Task ProcessAsync();
    }
}
