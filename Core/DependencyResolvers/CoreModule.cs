using Core.Caching;
using Microsoft.Extensions.DependencyInjection;
using Core.Utilities.IoC;
using Microsoft.Extensions.Configuration;
using Core.Caching.Redis;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager, RedisCacheManager>();
        }
    }
}
