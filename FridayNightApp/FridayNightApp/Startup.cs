using System;
using FridayNight.DAL;
using FridayNightApp.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace FridayNightApp
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //
            // Access appconfig all the way throughout the applicaton by using DI :  services.BuildServiceProvider().GetService<IOptions<ApplicationConfig>>()
            //
            services.Configure<ApplicationConfig>(
                _configuration.GetSection(nameof(ApplicationConfig))
                );


            services.AddDbContext<FNContext>(options =>
            {
                options.UseNpgsql(
                    services.BuildServiceProvider()
                    .GetService<IOptions<ApplicationConfig>>()
                    .Value
                    .Databases.PostgreSQL.ConnectionString
                    );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<FNContext>();
                context.Database.Migrate();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
