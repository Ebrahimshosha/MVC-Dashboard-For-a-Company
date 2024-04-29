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
	public class EmployeeRopository : GenericRepository<Employee>, IEmployeeRopository
	{
		//private readonly MVCdbcontext _dbcontext; 

		// → EmployeeRopository inherit this property from GenericRepository because this property there is private protected
		// and this property here will be private 

		public EmployeeRopository(MVCdbcontext dbcontext):base(dbcontext) 
		{
			//_dbcontext = dbcontext; 
		}

		public IQueryable<Employee> SearchEmployeesByName(string name)
		{
			return _dbcontext.Employees.Where(E => E.Name.ToLower().Contains(name.ToLower()));
		}

	}
}
