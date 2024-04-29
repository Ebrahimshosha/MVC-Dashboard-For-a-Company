using System.ComponentModel.DataAnnotations;

namespace PLDemoe.ViewModels
{
	public class RigisterViewModel
	{
		[Required(ErrorMessage = "FName is Required")]
		public string FName { get; set; }

		[Required(ErrorMessage = "LName is Required")]
		public string LName { get; set; }

		public string UserName { get; set; }

		[Required(ErrorMessage ="Email is Required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password is Required")]
		[Compare(nameof(Password), ErrorMessage = "Confirm Password doesn't match Password")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }

		public bool IsAgree { get; set; }



	}
}
