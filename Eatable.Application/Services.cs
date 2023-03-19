using Eatable.Application;
using Eatable.Application.General;
using Eatable.Application.StoreManager;
using Eatable.Application.UserManager;
using Microsoft.Extensions.DependencyInjection;

namespace Eatable.Application
{
    public static class Services
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IStoreManager, StoreManager.StoreManager>();
            services.AddTransient<ITranslationManager, TranslationManager>();
            services.AddTransient<IKeyIdentifierManager, KeyIdentifierManager>();
            services.AddTransient<IUserManager, UserManager.UserManager>();

            return services;
        }
    }
}