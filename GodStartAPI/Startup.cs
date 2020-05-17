using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GodStartAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using GodStartAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace GodStartAPI
{
    public class Startup
    {

        //readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });


            services.AddAutoMapper(c => c.AddProfile<AutoMapping>(), typeof(Startup));

            services.AddScoped<IJobRepository, JobRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IPostNumberRepository, PostNumberRepository>();

            services.AddCors();
            
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // the request, hereunder the session
            services.AddHttpContextAccessor();
            // add session support, remember to also add middleware support
            //services.AddSession();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod()
                );

            app.UseRouting();

            //app.UseCors("AllowMyOrigin");

            //app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
