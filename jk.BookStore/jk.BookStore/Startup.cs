using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jk.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ////Custom Middleware 
            //// asp.net is async 
            //app.Use(async (Context, Next) =>
            //{
            //    await Context.Response.WriteAsync("Hello from my first middleware");
            //    //Without Next (older dotnet have next) second middleware will not be run 
            //    await Next();
            //    await Context.Response.WriteAsync("Hello from my first middleware response");
            //});
            //app.Use(async (Context, Next) =>
            //{
            //    await Context.Response.WriteAsync("Hello from my second middleware");
            //    //Without Next (older dotnet have next) third middleware will not be run 
            //    await Next();
            //    await Context.Response.WriteAsync("Hello from my second middleware response");
            //});
            //app.Use(async (Context, Next) =>
            //{
            //    await Context.Response.WriteAsync("Hello from my third middleware");
            //    await Next();
            //});

            // Mapping the URL to a perticular resource 
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Added following method .... To pass to HomeController to Print J
                endpoints.MapDefaultControllerRoute();

                //MapGet Map is the method to map perticular URL to method
                //endpoints.Map("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    //MapGet Map is the method to map perticular URL to method
            //    endpoints.Map("/j", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello J!");
            //    });
            //});
        }
    }
}
