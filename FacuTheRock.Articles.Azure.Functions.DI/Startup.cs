using FacuTheRock.Articles.Azure.Functions.DI.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FacuTheRock.Articles.Azure.Functions.DI.Startup))]

namespace FacuTheRock.Articles.Azure.Functions.DI
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IGreetingService, GreetingService>();
        }
    }
}
