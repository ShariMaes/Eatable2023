using Eatable.Application.Product;
using Eatable.Data.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eatable.Application
{
    public static class Services
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IStoreManager, StoreManager>();

            services.AddTransient<IDBServices, DBServices>();
            services.AddTransient<IProductService, ProductService>();

            return services;
        }
    }
}
