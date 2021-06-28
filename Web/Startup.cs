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
using Domain.Entities.Basket;
using Stripe;

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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddSession();

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
            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.FromMinutes(0);
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

            //Product
            services.AddScoped<IProductService,Application.Services.ProductService>();
            services.AddScoped<IRepository<Domain.Entities.Product>,EfRepository<Domain.Entities.Product>>();

            //Basket
            services.AddScoped<IBasketService,BasketService>();
            services.AddScoped<IRepository<Basket>,EfRepository<Basket>>();

            //basketItem
            services.AddScoped<IRepository<BasketItem>,EfRepository<BasketItem>>();

            //Order
            services.AddScoped<IOrderService, Application.Services.OrderService>();
            services.AddScoped<IRepository<Domain.Entities.Order>, EfRepository<Domain.Entities.Order>>();

            //Post
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IRepository<Post>, EfRepository<Post>>();

            StripeConfiguration.ApiKey = Configuration["Stripe:SecretKey"];
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
                app.UseHttpsRedirection();
            }

            app.UseSession();
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
