using BLLDemo;
using BLLDemo.Interfaces;
using BLLDemo.Reposatories;
using DALDemo.Contexts;
using DALDemo.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PLDemoe.Controllers;
using PLDemoe.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLDemoe
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

			services.AddDbContext<MVCdbcontext>(Options =>
			{
				Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

			});

			//services.AddScoped<IDepartmentRepository, DepartmentRepository>();
			//services.AddScoped<IEmployeeRopository, EmployeeRopository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddAutoMapper(M => M.AddProfile(new EmployeeProfile()));
			services.AddAutoMapper(M => M.AddProfile(new DepartmentProfile()));
			services.AddAutoMapper(M => M.AddProfile(new UserProfile()));

			//services.AddScoped<UserManager<ApplicationUser>>();
			//services.AddScoped<SignInManager<ApplicationUser>>();
			//services.AddScoped<RoleManager<IdentityRole>>();
			services.AddIdentity<ApplicationUser, IdentityRole>(Options =>
			{
				Options.Password.RequireNonAlphanumeric = true;
				Options.Password.RequireDigit = true;
				Options.Password.RequireNonAlphanumeric = true;
				Options.User.RequireUniqueEmail = true;
				Options.Lockout.MaxFailedAccessAttempts = 10;
				Options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
			})  // To add interface that inside it Function signatures
				.AddEntityFrameworkStores<MVCdbcontext>()
				.AddDefaultTokenProviders();

			services.ConfigureApplicationCookie(Options =>
			{
				Options.LoginPath = "/Account/Login";
				Options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
			});

			//services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
			//	.AddCookie(Options =>
			//	{
			//		Options.LoginPath = "/Account/Login";
			//		Options.AccessDeniedPath = "/Home/Error";
			//	});
				
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

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
