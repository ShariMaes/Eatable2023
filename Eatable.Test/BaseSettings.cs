using AutoMapper;
using Eatable.Application.Automapper;
using Eatable.Application.General;
using Eatable.Application.StoreManager;
using Eatable.Application.UserManager;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Test
{
    public class BaseSettings
    {
        public static IServiceProvider _serviceProvider;

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
                mc.AddProfile(new UserProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IStoreManager, StoreManager>();
            services.AddTransient<IKeyIdentifierManager, KeyIdentifierManager>();
            services.AddTransient<IUserManager, UserManager>();
        }
    }
}
