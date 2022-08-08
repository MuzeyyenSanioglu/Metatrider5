using Metatrider5.Application.Services;
using Metatrider5.Application.Services.Interfaces;
using Metatrider5.Application.Settings;
using Metatrider5.Application.Settings.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Metatrider5.Application
{
    public static class DependcyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MT5ConnectionSettings>(configuration.GetSection(nameof(MT5ConnectionSettings)));
            services.AddSingleton<IMT5ConnectionSettings>(sp => sp.GetRequiredService<IOptions<MT5ConnectionSettings>>().Value);
            services.AddSingleton<IMT5Service, MT5Service>();
            return services;
        }
    }
}