using AutoMapper;
using Eatable.Application;
using Eatable.Application.Automapper;
using Eatable.Application.General;
using Eatable.Application.StoreManager;
using Eatable.Common.Enum;
using Eatable.Dto.General;
using Eatable.Dto.Store;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eatable.Test
{
    [TestClass]
    public class StoreManagerTest
    {
        private static IServiceProvider _serviceProvider;

        public void InitiateServices()
        {
           var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();


        }
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<EatableContext>(o => o.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eatable-D;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            //Automapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new StoreProfile());
                mc.AddProfile(new BaseProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IStoreManager, StoreManager>();
            services.AddTransient<IKeyIdentifierManager, KeyIdentifierManager>();

        }


        [TestMethod]
        public async Task AddNewStoreTest()
        {
            InitiateServices();
            var storeDto= CreateNewStore();

            var manager = _serviceProvider.GetService<IStoreManager>();
            var result = manager.AddStore(storeDto);

            Assert.IsNotNull(result);
        }

        private StoreDto CreateNewStore()
        {
            var storeDto = new StoreDto
            {
                StoreName = "TestCarrefour",
                Address = new AddressDto
                {
                    Street = "Zemstesteenweg",
                    City = "Mechelen",
                    HouseNumber = "250",
                    Postalcode = "2800",
                },
                StoreType = StoreType.PhysicalStore,
                OpeningHours = "Altijd open",
                ContactInformation = new List<ContactInformationDto>() {
                    new ContactInformationDto
                    {
                        ContactInfo = "info@carrefour.be",
                        ContactInformationTypeCode = ContactInformationType.Email
                    },
                     new ContactInformationDto
                     {
                         ContactInfo = "015 12 23 45",
                         ContactInformationTypeCode = ContactInformationType.Email
                     }
                },
                StoreUrl = "www.Carrefour.be",
                LogoName = null
            };

            return storeDto;
        }

    }
}
