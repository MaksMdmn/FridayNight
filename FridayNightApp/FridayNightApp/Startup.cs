using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using FridayNight.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FridayNightApp
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Refactor ? - app settings as an analog class of .json file
        private const string POSTGRESQL_CONNECTION_STRING = "PostgreSQL:ConnectionString";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FNContext>(options =>
            {
                var connectionString = _configuration.GetValue<string>(POSTGRESQL_CONNECTION_STRING);
                Console.WriteLine();
                options.UseNpgsql(
                    connectionString
                    //builder => builder.MigrationsAssembly(typeof(FNContext).Assembly.ManifestModule.Name.Replace(".dll", string.Empty))
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
