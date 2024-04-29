using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLDemo.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		// In Interface we Write : Signaturer of property - Signaturer of Methods - default implement method

		// Signaturer of property for every Repository 

		public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmployeeRopository EmployeeRopository { get; set; }

		Task<int> Complete();
    }
}
