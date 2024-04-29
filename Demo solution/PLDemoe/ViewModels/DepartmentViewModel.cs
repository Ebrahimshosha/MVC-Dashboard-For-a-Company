using DALDemo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace PLDemoe.ViewModels
{
	public class DepartmentViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Code is Required")]
		public string Code { get; set; }

		[Required(ErrorMessage = "Name is Required")]
		public string Name { get; set; }

		[Display(Name = "Date of Creation")]
		public DateTime CreatedDate { get; set; }


		// Navigational property [Many]
		public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

	}
}
