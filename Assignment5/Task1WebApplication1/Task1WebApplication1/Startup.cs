using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using Task1WebApplication1;
using System.Runtime.ConstrainedExecution;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
//using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;


namespace Task1WebApplication1
{
    public class Startup
    {
        private string msg;

        public IConfiguration Configuration { get; set; }

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.Run(async(context)=>
                { 
            var mag = Configuration["Message"];
            await context.Response.WriteAsync(msg);
        });



            //public IConfiguration Configuration { get; }





            DefaultFilesOptions options = new DefaultFilesOptions();

            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("htmlpage.html");

            app.UseDefaultFiles(options);

            //app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions()

            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "admin")),
                // have to use using System.IO
                RequestPath = new PathString("/Admin")
            } );

            // Add those two lines avobe all code, otherwise they will ot work
            app.Map("/m1", HandleMapOne);
            app.Map("/m2", appMap => {
                appMap.Run(async context =>
                {
                    await context.Response.WriteAsync("Hello from 2nd app.Map()");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from app.Run()");
            });

            //app.Use(async (context, next) =>

            //{
            //    await context.Response.WriteAsync("Before 1stapp.Use()\n");
            //    await next();
            //    await context.Response.WriteAsync("After 1stapp.Use()\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Before 2ndapp.Use()\n");
            //    await next();
            //    await context.Response.WriteAsync("After 2ndapp.Use()\n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello 1st app.Run()\n");
            //});

            //// the following will never be executed
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello 2nd app.Run()\n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync
            //    ("Hello World");
            //});

        }
        private static void HandleMapOne(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from 1st app.Map()");
            });
        }

    }
}
