using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AutoShop
{
    public class Startup
    {   //This is where to register dependecy injections
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //#Step5 - Use a AddTransient service i.e. when a ICarsRepository is requested, a new MockCarsRepository is returned everytime
            services.AddTransient<ICarsRepository, MockCarsRepository>();

            //###Step6 Create Controller folder##

            //services.AddSingleton<> - returns item once
            //services.AddScoped<>

            //#Step2
            services.AddMvc();
                       
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //#Step1 - Adding Middleware components
            app.UseDeveloperExceptionPage(); //Alerts you when something goes wrong with an exception (Use only in Development stages)
            app.UseStatusCodePages(); //Return status 400 or 500 when there is a page error
            app.UseStaticFiles(); //Looks and serve static files for application
            app.UseMvcWithDefaultRoute(); //
        }
    }
}
