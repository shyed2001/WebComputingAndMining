// https://codedocu.com/Net-Framework/ASP_dot_Net-Core/Files-Folders/Asp_dot_Core_colon_-User-files-in-external-directory-were-stored-outside-the-project?2824
// https://www.youtube.com/watch?v=gea72EnlGNA


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;

namespace As5Task6
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {



          //  // Task 5 starts
          //  DefaultFilesOptions options = new DefaultFilesOptions();

          //  options.DefaultFileNames.Clear();
          //  options.DefaultFileNames.Add("htmlpage.html");

          //app.UseDefaultFiles(options); //// For Task 4 and Task 5

          //// app.UseDefaultFiles(); //// For Task 4 and
          ///
          // app.UseStaticFiles(); /// For task 4 and Task 5 and Task 6
          //  // Task 5 Ends



            // Task Two Start
            // app.Use(async (context, next) =>

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

            //  Task Two End });

            //// Task Three Starts
            //// Add those two lines avobe all code, otherwise they will ot work

            //app.Map("/m1", HandleMapOne);
            //app.Map("/m2", appMap =>
            //{
            //    appMap.Run(async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from 2nd app.Map()");
            //    });
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello from app.Run()");
            //});

            //// Task Three Ends


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


            // Task 6 starts
            // app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()

            {
             FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "admin")),

               /// FileProvider = new PhysicalFileProvider( Path.Combine(env.ContentRootPath, "..\\admin")),
                // have to use using System.IO and
                // using Microsoft.Extensions.FileProviders;
               RequestPath = new PathString("/Admin")
                /// RequestPath = "/admin"
            });

            app.UseRouting();

            app.UseAuthorization();

            // Task 6 Ends

            // Task one start
            //// app.UseAuthorization();

            ////app.UseEndpoints(endpoints =>
            ////{
            ////    endpoints.MapRazorPages();
            ////});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync
            //    ("Hello World");
            //});

            //  Task One End 
        }

        // Task 3 second part start
        private static void HandleMapOne(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from 1st app.Map()");
            });
        }
        // Task 3 second part ends
    }
}


/*
 using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
//using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;


namespace Assmnt5WebApplication1
{
    public class Startup
    {
        public string msg;

        public IConfiguration Configuration { get; set; }  // For task 7

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

       
        public Startup()  // For Task 7
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        } // For Task 7

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) // For Task 7
        {
            // IServiceCollection.AddAuthorization();
        } // For Task 7

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) // For Task 7
        {

            // Task 5 starts
            DefaultFilesOptions options = new DefaultFilesOptions();

            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("htmlpage.html");

            // app.UseDefaultFiles(options); //// For Task 4 and Task 5

            // app.UseDefaultFiles(); //// For Task 4 and
            //app.UseStaticFiles(); /// For task 4 and Task 5 and Task 6
            // Task 5 Ends
         
            if (env.IsDevelopment())

                app.Run(async (context) =>
                {
                    var msg = Configuration["Message"];
                    await context.Response.WriteAsync(msg);
                }); // For Task 7



            //public IConfiguration Configuration { get; }



           // Task 6 starts
            app.UseStaticFiles(new StaticFileOptions()

            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "admin")),
                 // have to use using System.IO and
                // using Microsoft.Extensions.FileProviders;
                RequestPath = new PathString("/Admin")
            });

           // Task 6 Ends

           // Task Three Starts
            // Add those two lines avobe all code, otherwise they will ot work
            app.Map("/m1", HandleMapOne);
            app.Map("/m2", appMap =>
            {
                appMap.Run(async context =>
                {
                    await context.Response.WriteAsync("Hello from 2nd app.Map()");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from app.Run()");
            });
            
           // Task Three Ends

            // Task Two Start
            // app.Use(async (context, next) =>

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

            //  Task Two End });

        

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


   // Task one start
            //// app.UseAuthorization();

            ////app.UseEndpoints(endpoints =>
            ////{
            ////    endpoints.MapRazorPages();
            ////});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync
            //    ("Hello World");
            //});

  //  Task One End 

        }
       
      // Task 3 second part start
        private static void HandleMapOne(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Hello from 1st app.Map()");
    });
}
      // Task 3 second part ends
    }
}


    */