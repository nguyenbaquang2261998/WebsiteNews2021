using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using DOLPHIN.Mapping;
using DOLPHIN.Model;
using DOLPHIN.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DOLPHIN
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IContainer ApplicationContainer { get; private set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            services.AddMemoryCache();

            // _ = services.AddAutoMapper(c => c.AddProfile(new DtoProfile()));
            services.AddAutoMapper(typeof(DtoProfile));
            services.AddSingleton(this.Configuration);
            services.AddControllersWithViews();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllers(options => options.EnableEndpointRouting = false);
            services.AddRazorPages().AddMvcOptions(options => options.EnableEndpointRouting = false);
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EfModule());
            builder.RegisterModule(new LoggerModule());
            builder.RegisterModule(new MappingModule());
            builder.RegisterModule(new UnitOfWorkModule());
            builder.RegisterModule(new HelperModule());
            this.ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);
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
            app.UseSession();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}"
                    );

                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
