using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Api_covid.data;
using Api_covid.data.Repository;

namespace WebServerCovid
{
    public class Startup
    {
        readonly string allowSpecificOrigins = "_allowSpecificOrigins";


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(allowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("https://localhost:5002")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                });
            });
            var connect_postgre = new Config_postgres(Configuration.GetConnectionString("Config_postgres"));
            services.AddSingleton(connect_postgre);
            services.AddScoped<ICovid, Provin_reposito>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(allowSpecificOrigins);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
