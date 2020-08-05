using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.Models;
using StudentEnrollmentAPI.Models.Interfaces;
using StudentEnrollmentAPI.Models.Services;

namespace StudentEnrollmentAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        // the appsettings.json, by default, is our "Configurations" for the app. 
        // Set ourselves up for Dependency Injection
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // this is where all of our dependencies are going to live. 
            // Enable the use of using controllers within the MVC convention
            // Install - Package Microsoft.AspNetCore.Mvc.NewtonsoftJson - Version 3.1.2
            services.AddControllersWithViews(options =>
            {
                // Make all routes by default authorized to require login
                options.Filters.Add(new AuthorizeFilter());
            })
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            // Register with the app, that the database exists, and what options to use for it. 
            services.AddDbContext<SchoolEnrollmentDbContext>(options =>
           {
               // Install-Package Microsoft.EntityFrameworkCore.SqlServer
               // Connection String = location where something lives. In our case, it's where our DB lives. 
               // connection string contains the location, username, pw of your sql server...with our sql database directly.
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
           });

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<SchoolEnrollmentDbContext>()
                    .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["JWTIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTKey"]))
                };
            });


            // Add my policies.
            services.AddAuthorization(options =>
           {
               options.AddPolicy("ElevatedPrivlidges", policy => policy.RequireRole(ApplicationRoles.Principal, ApplicationRoles.Advisor));
               options.AddPolicy("ColorPolicy", policy => policy.RequireClaim("FavoriteColor"));
           });

            // register my Dependency Injection Services
            services.AddTransient<IStudent, StudentRepository>();
            services.AddTransient<ICourse, CourseRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // VERY IMPORTANT!
            app.UseStaticFiles();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            RoleInitializer.SeedData(serviceProvider, userManager, Configuration);

            app.UseEndpoints(endpoints =>
            {
                // Set our default routing for our request within the API application
                // By default, our convention is {site}/[controller]/[action]/[id]
                // id is not required, allowing it to be nullable
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
