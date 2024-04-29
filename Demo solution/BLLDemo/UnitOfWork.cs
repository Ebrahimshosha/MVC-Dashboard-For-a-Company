using BLLDemo.Interfaces;
using BLLDemo.Reposatories;
using DALDemo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLDemo
{
	public class UnitOfWork : IUnitOfWork

	{
		private readonly MVCdbcontext _dbcontext;

		public IDepartmentRepository DepartmentRepository { get; set; } // Automatic Property because we are in class → CLR Will Generate backing field hiden private Attribut
		public IEmployeeRopository EmployeeRopository { get; set; }    // Automatic Property because we are in class

        public UnitOfWork(MVCdbcontext dbcontext) // Ask from CLR that create object from DbContext

		{
			DepartmentRepository = new DepartmentRepository(dbcontext);

			EmployeeRopository = new EmployeeRopository(dbcontext);
			_dbcontext = dbcontext;
		}

		public async Task<int> Complete()
		
			=> await _dbcontext.SaveChangesAsync();

		public void Dispose()
			=> _dbcontext.Dispose();
	}
}
