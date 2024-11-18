using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Email;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ideaMarket
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
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();//adding api calls
            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()//Using EFCore to retrieve user and role information from underlying DB
                    .AddDefaultTokenProviders()
                    .AddDefaultUI();
            services.AddMvc();
            services.AddTransient<IEmailSender, DevEmailSender>();
            services.Configure<IdentityOptions>(options =>
            {
                //SigIn settings
                options.SignIn.RequireConfirmedEmail = true;
                //options.Tokens.EmailConfirmationTokenProvider = "emailConfirmation";
                options.User.RequireUniqueEmail = true;
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            });

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
                app.UseExceptionHandler("/Administration/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=UserIdentity}/{action=Index}/{id?}");
            });
        }
    }
}
