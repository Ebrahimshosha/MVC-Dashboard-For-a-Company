using DALDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDemo.Contexts.Configration
{
	public class DepartmentConfigration : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> builder)
		{
			// Fluent Apis

			builder.Property(D=>D.Id).UseIdentityColumn(10,10);
		}
	}
}
