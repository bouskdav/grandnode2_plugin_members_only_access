using Grand.Business.Core.Interfaces.Cms;
using Grand.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Widgets.MembersOnly.Infrastructure.Middleware;
using Widgets.MembersOnly.Services;

namespace Widgets.MembersOnly
{
    public class StartupApplication : IStartupApplication
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IWidgetProvider, MembersOnlyWidgetProvider>();
            services.AddScoped<IMembersOnlyService, MembersOnlyService>();
        }

        public int Priority => 10;

        public void Configure(IApplicationBuilder application, IWebHostEnvironment webHostEnvironment)
        {
            // order here matters - after UseAuthentication so we have the Identity populated in the HttpContext
            application.UseMiddleware<MembersOnlyMiddleware>();
        }

        public bool BeforeConfigure => false;
    }

}
