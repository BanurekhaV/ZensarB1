using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePrj2.Models;

namespace CorePrj2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            // services.AddControllersWithViews();

            //1. one way of registering the services
            //by default service would be singleton
            //or you can explicitly specify the lifetime access
           // services.Add(new ServiceDescriptor(typeof(IStudentRepository), new StudentRepository()));
           // services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository), ServiceLifetime.Singleton));

            //2. other way of registering the services with the services objects extension method
            services.AddSingleton<IStudentRepository, StudentRepository>();
           // services.AddSingleton(typeof(IStudentRepository), typeof(StudentRepository));
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions depo = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 5
                };
                app.UseDeveloperExceptionPage();
            }
            // 4.we can use FileServer middleware to handle both default files and static files middleware
            //FileServerOptions fso = new FileServerOptions();
            //fso.DefaultFilesOptions.DefaultFileNames.Clear();
            //fso.DefaultFilesOptions.DefaultFileNames.Add("MyHtmlPage.html");
            //app.UseFileServer(fso);

            /*//3. to specify a customized html file as a domain default
            DefaultFilesOptions dfo = new DefaultFilesOptions();
            dfo.DefaultFileNames.Clear();
            dfo.DefaultFileNames.Add("MyHtmlPage.html");
            //2. set up default file index.html to the domain of the site
            app.UseDefaultFiles(dfo);
            //1. use static files middleware to serve any static files
            app.UseStaticFiles();*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapGet("/", async context =>
                //{
                //   // throw new Exception("Error occured in the server while processing your request..");
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });

        }
    }
}
