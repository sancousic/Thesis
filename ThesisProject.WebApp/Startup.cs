using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using ThesisProject.Data;
using ThesisProject.Data.Domain;
using ThesisProject.Data.Services;
using ThesisProject.WebApp.Options;

namespace ThesisProject.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment applicationEnvironment)
        {
            this.Configuration = configuration;
            this.CurrentEnvironment = applicationEnvironment;
        }

        public IConfiguration Configuration { get; }

        private IWebHostEnvironment CurrentEnvironment { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging((Action<ILoggingBuilder>)(logggingBuilder => logggingBuilder.AddNLog("nlog.config")));
            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
            if (this.CurrentEnvironment.IsDevelopment())
                services.AddDbContext<AppDbContext>((Action<DbContextOptionsBuilder>)(options => options.UseMySql(this.Configuration.GetConnectionString("DefaultConnection"), (ServerVersion)serverVersion, (Action<MySqlDbContextOptionsBuilder>)(options => options.MigrationsAssembly("ThesisProject.Data")))));
            else
                services.AddDbContext<AppDbContext>((Action<DbContextOptionsBuilder>)(options => options.UseSqlServer(this.Configuration.GetConnectionString("SQLServer"))));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<AppUser>((Action<IdentityOptions>)(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 1;
                options.Password.RequiredUniqueChars = 1;
            })).AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddAuthentication().AddFacebook((Action<FacebookOptions>)(facebookOptions =>
            {
                facebookOptions.AppId = this.Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = this.Configuration["Authentication:Facebook:AppSecret"];
                facebookOptions.AccessDeniedPath = (PathString)"/Login";
            }));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            IConfigurationSection section = this.Configuration.GetSection("EmailSettings");
            services.Configure<EmailSettings>((IConfiguration)section);
            services.AddRazorPages();
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddTransient<IEmailSender, ThesisProject.WebApp.Services.EmailSender>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IPacientService, PacientService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IServicesService, ServicesService>();
            services.AddScoped<IStatsService, StatsService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints((Action<IEndpointRouteBuilder>)(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            }));
        }
    }
}
