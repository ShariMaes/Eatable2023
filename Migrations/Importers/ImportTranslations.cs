using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Importers
{
    public class ImportTranslations
    {
        public async Task ProcessAsync(string path, string sheetOption)
        {
            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                if (sheetOption.Equals("All"))
                {
                    var worksheetLabel = package.Workbook.Worksheets["Label"];
                    var worksheetEnum = package.Workbook.Worksheets["Enum"];
                    var worksheetError = package.Workbook.Worksheets["Error"];

                    foreach (var column in worksheetLabel.Columns)
                    {
                       
                    }
                    
                }
            }
        }
    }
}
