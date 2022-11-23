using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyReatesApp.Services
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAutoMapper(typeof(ApplicationMapper));

            services.AddHttpClient("JsonPlaceHolderApiClient", o => {
                o.BaseAddress = new Uri("https://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=");
            });

            //var conString = configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<AppDbContext>(options =>
            //                    options.UseNpgsql(conString));

            //services.AddTransient<UserService>();
            //services.AddTransient<UserRepository>();
            //services.AddTransient<IJsonPlaceholderApiClient, JsonPlaceholderApiClient>();
            //services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
