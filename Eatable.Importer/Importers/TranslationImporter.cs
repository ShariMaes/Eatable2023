using Eatable.Application;
using Eatable.Common.Enum;
using Eatable.Data.General;
using Eatable.EF;
using IronXL;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Importer.Importers
{
    public class TranslationImporter : BaseImporter, ITranslationImporter
    {
        private readonly DbContextOptionsBuilder<EatableContext> _builder = new DbContextOptionsBuilder<EatableContext>();
        public TranslationImporter(IHttpContextAccessor httpContextAccessor): base(httpContextAccessor)
        {
            _builder = new DbContextOptionsBuilder<EatableContext>();
            _builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eatable-D;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public async Task ProcessAsync()
        {
           await ProcessAsync("All");
        }

        public async Task ProcessAsync(string input = "All")
        {
            using var eatableContext = new EatableContext(_builder.Options, _httpContextAccessor);
            var tranlations = eatableContext.Translation.ToList();
          
            Console.WriteLine("Reading file");
            List<Translation> data = ReadFile(input);
            Console.WriteLine($"{data.Count} records found");

            await eatableContext.AddRangeAsync(data);

            await eatableContext.SaveChangesAsync();
        }

        private List<Translation> ReadFile(string input = "All")
        {
            var list = new List<Translation>();
            var fileLocation = @"D:\Documents\GitHub\Eatable\Eatable.Importer\Files\Translations.xlsx";

            bool processLabel = false;
            bool processEnum = false;
            bool processError = false;

            if (input.Equals("All"))
            {
                processLabel = true;
                processEnum = true;
                processError = true;
            }
            if (input.Equals("1"))
            {
                processLabel = true;
                processEnum = false;
                processError = false;
            }
            if (input.Equals("2"))
            {
                processLabel = false;
                processEnum = true;
                processError = false;
            }
            if (input.Equals("3"))
            {
                processLabel = false;
                processEnum = false;
                processError = true;
            }

            var worksheetLabelName = "Label";
            var worksheetEnumName = "Enum";
            var worksheetErrorName = "Error";

            var workBook = WorkBook.Load(fileLocation);

            if (processLabel)
            {
                Console.WriteLine("Processing label tab");
                var workSheetLabel = workBook.GetWorkSheet(worksheetLabelName);

                for (int i = 2; i < workSheetLabel.RowCount + 1; i++)
                {
                    string cellTranslationIdentifier = workSheetLabel["A" + i].StringValue;
                    string cellModuleType = workSheetLabel["B" + i].StringValue;
                    string cellNld = workSheetLabel["C" + i].StringValue;
                    string cellFra = workSheetLabel["D" + i].StringValue;
                    string cellEng = workSheetLabel["E" + i].StringValue;
                    string cellDeu = workSheetLabel["F" + i].StringValue;
                    string cellValidUntil = workSheetLabel["G" + i].StringValue;


                    var translation = new Translation
                    {
                        TranslationIdentifier = cellTranslationIdentifier,
                        TranslationType = TranslationType.Label,
                        ModuleType = (ModuleType)Enum.Parse(typeof(ModuleType), cellModuleType),
                        Nld = cellNld,
                        Fra = cellFra,
                        Eng = cellEng,
                        Deu = cellDeu,
                        ValidUntil = !cellValidUntil.IsNullOrEmpty() ? DateTime.Parse(cellValidUntil) : null,
                    };

                    list.Add(translation);
                }
            }

            if (processEnum)
            {
                Console.WriteLine("Processing enum tab");

                var worksheetEnum = workBook.GetWorkSheet(worksheetEnumName);

                for (int i = 2; i < worksheetEnum.RowCount + 1; i++)
                {
                    string cellTranslationIdentifier = worksheetEnum["A" + i].StringValue;
                    string cellModuleType = worksheetEnum["B" + i].StringValue;
                    string cellNld = worksheetEnum["C" + i].StringValue;
                    string cellFra = worksheetEnum["D" + i].StringValue;
                    string cellEng = worksheetEnum["E" + i].StringValue;
                    string cellDeu = worksheetEnum["F" + i].StringValue;
                    string cellValidUntil = worksheetEnum["G" + i].StringValue;


                    var translation = new Translation
                    {
                        TranslationIdentifier = cellTranslationIdentifier,
                        TranslationType = TranslationType.Enum,
                        ModuleType = (ModuleType)Enum.Parse(typeof(ModuleType), cellModuleType),
                        Nld = cellNld,
                        Fra = cellFra,
                        Eng = cellEng,
                        Deu = cellDeu,
                        ValidUntil = !cellValidUntil.IsNullOrEmpty() ? DateTime.Parse(cellValidUntil) : null,
                    };

                    list.Add(translation);
                }
            }

            if (processError)
            {
                Console.WriteLine("Processing error tab");

                var workSheetError = workBook.GetWorkSheet(worksheetErrorName);

                for (int i = 2; i < workSheetError.RowCount + 1; i++)
                {
                    string cellTranslationIdentifier = workSheetError["A" + i].StringValue;
                    string cellModuleType = workSheetError["B" + i].StringValue;
                    string cellNld = workSheetError["C" + i].StringValue;
                    string cellFra = workSheetError["D" + i].StringValue;
                    string cellEng = workSheetError["E" + i].StringValue;
                    string cellDeu = workSheetError["F" + i].StringValue;
                    string cellValidUntil = workSheetError["G" + i].StringValue;


                    var translation = new Translation
                    {
                        TranslationIdentifier = cellTranslationIdentifier,
                        TranslationType = TranslationType.Error,
                        ModuleType = (ModuleType)Enum.Parse(typeof(ModuleType), cellModuleType),
                        Nld = cellNld,
                        Fra = cellFra,
                        Eng = cellEng,
                        Deu = cellDeu,
                        ValidUntil = !cellValidUntil.IsNullOrEmpty() ? DateTime.Parse(cellValidUntil) : null,
                    };

                    list.Add(translation);
                }
            }
            return list;
        }

    }
}
