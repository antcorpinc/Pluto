using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pluto.Data;
using Pluto.Models;
using Pluto.Services;
using Pluto.Services.Interfaces;
using Pluto.Web.Core;
//using Pluto.Web.Services;

namespace Pluto.Web
{
    public class Startup
    {

        private readonly IHostingEnvironment _environment;
        public IConfigurationRoot _configurationRoot { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            _environment = env;

            builder.AddEnvironmentVariables();
            _configurationRoot = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<PlutoContext>(
                options =>
                {
                    options.UseSqlServer(
                        _configurationRoot.GetConnectionString("PlutoContextConnection"));
                });

            services.AddTransient<PlutoContextSeedData>();
            
            services.AddIdentity<PlutoUser, PlutoRole>()
                    .AddEntityFrameworkStores<PlutoContext>();
            //Refactor : Not Used Anymore
         //   services.AddTransient<IUserProfileService,UserProfileService>();
            
            services.AddTransient<ISecurityService,SecurityService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            PlutoContextSeedData seeder )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute("spa-fallback",
                new {controller="Home", action="Index"});
            });

            seeder.SeedAsync().Wait();

            /*app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}