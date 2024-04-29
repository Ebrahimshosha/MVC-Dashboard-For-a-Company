using DALDemo.Models;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace PLDemoe.ViewModels
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is Required")]
		[MaxLength(50, ErrorMessage = "Max Length of Name is 50 Chars")]
		[MinLength(5, ErrorMessage = "Min Length of Name is 5  Chars")]
		public String Name { get; set; }

		[Range(22, 30)]
		public int? Age { get; set; }

		[RegularExpression("^[1-9]{1,3}-[a-zA-Z]{4,10}-[a-zA-Z]{3,10}-[a-zA-Z]{3,10}$"
			, ErrorMessage = "Address Must be like 123-street-city-country")]
		public string Address { get; set; }

		[DataType(DataType.Currency)]
		public decimal Salary { get; set; }

		public bool IsActive { get; set; }

		[EmailAddress]
		public string Email { get; set; }

		[Phone]
		public string PhoneNumber { get; set; }

		public DateTime HireDate { get; set; }

		public IFormFile Image { get; set; }
		public string ImageName { get; set; }


		//[ForeignKey("Department")]
		public int? DepartmentId { get; set; } // Foreign Key  => Allow Null

		// Navigational property [One]
		public Department Department { get; set; }
	}
}
