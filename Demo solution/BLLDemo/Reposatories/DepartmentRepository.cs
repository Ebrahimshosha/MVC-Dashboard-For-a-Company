using BLLDemo.Interfaces;
using DALDemo.Contexts;
using DALDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLDemo.Reposatories
{
	public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
	{
		public DepartmentRepository(MVCdbcontext dbcontext) : base(dbcontext) 
		{
			
		}

	}
}
