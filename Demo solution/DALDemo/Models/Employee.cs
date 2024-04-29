using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDemo.Models
{
	public class Employee
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public String Name { get; set; }

		public int? Age { get; set; }

		public string Address { get; set; }

		[DataType(DataType.Currency)]
		public string Salary { get; set; }

		public bool IsActive { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public DateTime HireDate { get; set; }

		public DateTime CreationDate { get; set; } = DateTime.Now;

		public string ImageName { get; set; }

		//[ForeignKey("Department")]
		public int? DepartmentId { get; set; } // Foreign Key  => Allow Null
		 // FK Optional => On Delete : Restrict  → Error if U want to delete department and this department in relation with employees
		 // FK Required => On Delete : Cascade   → if U want to delete department , Will delete employees in this department

		// Navigational property [One]
		public Department Department { get; set; }
	}
}
