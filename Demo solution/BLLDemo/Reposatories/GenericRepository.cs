using BLLDemo.Interfaces;
using DALDemo.Contexts;
using DALDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLDemo.Reposatories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private protected readonly MVCdbcontext _dbcontext;
		public GenericRepository(MVCdbcontext dbcontext) // No Dependency Injection here 
		{
			_dbcontext = dbcontext;
		}

		public async Task Add(T item)
			=> await _dbcontext.Set<T>().AddAsync(item);

		public void Delete(T item)
			=> _dbcontext.Set<T>().Remove(item); // Remove doesn't work async because it only change object state to deattached and doesn't have internaly code to work async

		public void Update(T item) 
			=> _dbcontext.Set<T>().Update(item); // Update doesn't work async because it only change object state to Modified   and doesn't have internaly code to work async

		public async Task<T> Get(int id)
		{
			//var Dep = _dbcontext.Departments.Local.Where(D => D.Id == id).FirstOrDefault();

			//if (Dep is null)
			//{
			//	Dep = _dbcontext.Departments.Where(D => D.Id == id).FirstOrDefault();
			//}

			//return Dep;

			return await _dbcontext.Set<T>().FindAsync(id);
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			if (typeof(T) == typeof(Employee))
			{
				return (IEnumerable<T>) await _dbcontext.Employees.AsNoTracking().Include(E => E.Department).ToListAsync();
			}
			else
				return await _dbcontext.Set<T>().ToListAsync();
		}
	}
}
