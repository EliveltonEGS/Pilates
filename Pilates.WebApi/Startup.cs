using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pilates.EntityFramework.Data;
using Pilates.WebApi.Providers;

namespace Pilates.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {   
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("Database"));

            RegisterServices(services);

            //habilta outro dom�nio
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
                });
            });

            services.AddControllers();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            //CadastrosBase
            services.AddCadastroBaseServices();

        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("EnableCORS");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
