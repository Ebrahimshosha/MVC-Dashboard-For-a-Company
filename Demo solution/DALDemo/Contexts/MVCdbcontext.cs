using DALDemo.Contexts.Configration;
using DALDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALDemo.Contexts
{
	public class MVCdbcontext : IdentityDbContext<ApplicationUser>
	{
        public MVCdbcontext(DbContextOptions<MVCdbcontext> options): base(options) 
        {
            
        }
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//	=> optionsBuilder.UseSqlServer("Server = .; Database = MVC1Db; Trusted_Connection = True; MultipleActiveResultSets = True ");
		// MultipleActiveResultSets = True → To Make more than Query

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Call Configration Classes
			//builder.Entity<IdentityUser>.ToTable("Users");

			//builder.ApplyConfiguration<Department>(new DepartmentConfigration());
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<IdentityUser> Users { get; set; }
        //public DbSet<IdentityRole> Roles { get; set; }
	}
}
