using DALDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLDemo.Interfaces
{
	public interface IEmployeeRopository :IGenericRepository<Employee>
	{
		IQueryable<Employee> SearchEmployeesByName(string name);
	}
}
