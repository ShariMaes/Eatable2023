using AutoMapper;
using Eatable.Application.Automapper;
using Eatable.EF;
using Eatable.Importer.Importers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Security.Authentication.ExtendedProtection;

namespace Eatable.Importer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            await InputOptions(serviceProvider);
        }

        private static async Task InputOptions(IServiceProvider serviceProvider)
        {
            Console.WriteLine(@"Choose migration");
            Console.WriteLine(@"    ");
            Console.WriteLine(@"1: Translations");
            Console.WriteLine(@"2: Roles and rights");

            Console.Write(@"Choice: ");
            var input = Console.ReadLine();
            if (input.IsNullOrEmpty())
            {
                Console.Write(@"Choice: ");
                input = Console.ReadLine();
            }

            if (input.IsNullOrEmpty())
            {
                Console.WriteLine(@"End task");
            }
            else
            {
                if (input.Equals("1"))
                {
                    Console.WriteLine(@"Choose tabs");
                    Console.WriteLine(@"    ");
                    Console.WriteLine(@"All: All tabs");
                    Console.WriteLine(@"1: Label");
                    Console.WriteLine(@"2: Enum");
                    Console.WriteLine(@"3: Error");
                    Console.Write(@"Choice: ");
                    var input2 = Console.ReadLine();

                    Console.WriteLine(@"Start importing translations");
                    var s = serviceProvider.GetService<ITranslationImporter>();
                    await s.ProcessAsync(input2);
                }
                if (input.Equals("2"))
                { 
                    Console.WriteLine(@"Start importing roles and rights");
                    var s = serviceProvider.GetService<IRoleImporter>();
                    await s.ProcessAsync();

                }
            }          

            Console.WriteLine(@"End task");
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Automapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new StoreProfile());
                mc.AddProfile(new BaseProfile());
                mc.AddProfile(new UserProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<EatableContext>(o => o.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eatable-D;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddTransient<ITranslationImporter, TranslationImporter>();
            services.AddTransient<IRoleImporter, RoleImporter>();
        }
    }
}