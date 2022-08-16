using Gnostice.Controls.ASP;
using Gnostice.Controls.ASP.ASPNETCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12
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
            services.AddRazorPages();
            
            services.AddSingleton<ServerEventsHandler, DocumentViewerServerEventHandler>();
            
            services.AddMemoryCache();

            // Uncomment if you want to use database caching for Gnostice Document Viewer
            //services.AddDbContext<EFCoreDocumentViewerDbContext>(options =>
            //{
            //    options.UseInMemoryDatabase(Configuration.GetConnectionString("memory"));
                
            //}, ServiceLifetime.Transient);
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.Map("/DocumentHandler.axd", appMap => appMap.UseGnosticeDocumentViewerMiddleware());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
