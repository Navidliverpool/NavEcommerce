using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NavEcommerce.infrastructures;
using NavEcommerce.infrastructures.DbContextInstances;
using NavEcommerce.Models;
using NavEcommerce.infrastructures.Repositories;

namespace NavEcommerce
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
            services.AddControllersWithViews();
            services.AddDbContext<NavEcommerceDbContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")).EnableSensitiveDataLogging());

            //Ba estefade az in dige ehtaj nist dune dune hameye repositoryharo inja to services.AddScoped ezafe konam.
            //baraye khate pain mitunam morajeye konam be "https://stackoverflow.com/questions/2173107/what-exactly-is-an-open-generic-type-in-net"
            //services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            services.AddTransient<IGenericRepo<Motorcycle>, MotorcycleRepo>();
            services.AddTransient<IGenericRepo<Brand>, BrandRepo>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IDataCombiner, DataCombiner>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
