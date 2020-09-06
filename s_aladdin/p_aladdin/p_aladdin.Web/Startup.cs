using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace p_aladdin
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Latest);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            { app.UseDeveloperExceptionPage(); }

            app.UseFileServer();        // Serve static file            
            app.UseMvc();               // Serve API functions

            _c_db l_dal_ = new _c_db();
            if (env.IsDevelopment())
            {
                l_dal_.Database.EnsureDeleted();
            }
            l_dal_.Database.EnsureCreated();
        }
    }
}