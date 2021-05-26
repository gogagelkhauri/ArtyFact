using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure.Data;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using Infrastructure.EmailService;
using Domain.Interfaces.Services;
using Domain.Interfaces;
using Domain.Entities;
using Application.Services;

namespace Web
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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
            
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>  
            {  
                options.Cookie.IsEssential = true;
                options.LoginPath = $"/Identity/account/login";  
                options.LogoutPath = $"/Identity/account/logout";  
            });  

            //automapper
            services.AddAutoMapper(typeof(Startup));

            //EmailServices
            var emailConfig = Configuration
                .GetSection("EmailConfiguration")
                .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
            services.AddScoped<IEmailSender, EmailSender>();

            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));

            //Dependency Injection

            //Category
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IRepository<Category>,EfRepository<Category>>();

            //User profile
            services.AddScoped<IUserProfileService,UserProfileService>();
            services.AddScoped<IRepository<UserProfile>,EfRepository<UserProfile>>();

            //User profile
            //services.AddScoped<IUserProfileService, UserProfileService>();
            //services.AddScoped<IRepository<UserCategory>, EfRepository<UserCategory>>();

            //Paint type
            services.AddScoped<IPaintTypeService,PaintTypeService>();
            services.AddScoped<IRepository<PaintType>,EfRepository<PaintType>>();

            //Product
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IRepository<Product>,EfRepository<Product>>();

            //services.AddRazorPages();

            //cookies
            
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

            //app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
               // endpoints.MapRazorPages();
            });
        }
    }
}
