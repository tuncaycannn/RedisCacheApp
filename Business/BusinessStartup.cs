using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Business
{
    public partial class BusinessStartup
    {
        public BusinessStartup(IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            Configuration = configuration;
            HostEnvironment = hostEnvironment;
        }

        public IConfiguration Configuration { get; }

        protected IHostEnvironment HostEnvironment { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <remarks>
        /// It is common to all configurations and must be called. Aspnet core does not call this method because there are other methods.
        /// </remarks>
        /// <param name="services"></param>
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();

            var coreModule = new CoreModule();

            services.AddDependencyResolvers(Configuration, new ICoreModule[] { coreModule });

            services.AddSingleton<ConfigurationManager>();
        }
    }
}