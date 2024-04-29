using DALDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PLDemoe.Helpers;
using PLDemoe.ViewModels;
using System.Threading.Tasks;

namespace PLDemoe.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;


		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		#region Register

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken] // To handle internal request Only
		public async Task<IActionResult> Register(RigisterViewModel model)
		{
			if (ModelState.IsValid) // Server Side Validation
			{
				var user = await _userManager.FindByNameAsync(model.UserName);
				
				if (user is null)
				{
					user = new ApplicationUser()
					{
						FName = model.FName,
						LName = model.LName,
						UserName = model.Email.Split('@')[0],
						Email = model.Email,
						IsActive = model.IsAgree,
					};

					var result = await _userManager.CreateAsync(user, model.Password);

					if (result.Succeeded)
						return RedirectToAction(nameof(Login));

					foreach (var error in result.Errors)
						ModelState.AddModelError(string.Empty, error.Description);
				}

				ModelState.AddModelError(string.Empty, "UserName is Already exists :( ");


			}
			return View(model);
		}

		#endregion

		#region Login

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken] // To handle internal request Only
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);

				if (user is not null)
				{
					var flag = await _userManager.CheckPasswordAsync(user, model.Password);
					if (flag)
					{
						var Result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

						if (Result.Succeeded)
							return RedirectToAction(nameof(HomeController.Index), "Home");
					}
					ModelState.AddModelError(string.Empty, "Password is not Correct");
				}
				ModelState.AddModelError(string.Empty, "Email is not Existed");
			}
			return View(model);
		}

		#endregion

		#region SignOut

		public new async Task<IActionResult> SignOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction(nameof(Login));
		}

		#endregion

		#region ForgetPassword
		
		public IActionResult ForgetPassword()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken] // To handle internal request Only
		public async Task<IActionResult> SendResetPasswordURL(ForgetPasswordViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);
				if (user is not null)
				{
					var token = await _userManager.GeneratePasswordResetTokenAsync(user); // Unique for this user for one time // Must Allow DI for TokenProviders
                    var ResetPassword = Url.Action("ResetPassword", "Account", new { email = model.Email, token = token }, Request.Scheme);

					var email = new Email()
					{
						Subject = "Reset Your Password",
						To = model.Email,
						Body = ResetPassword
					};
					EmailSettings.SendEmail(email);
					return RedirectToAction(nameof(CheckYourInbox));
				}
				ModelState.AddModelError(string.Empty, "Invalid Email");
			}
			return View(model);
		}

		public IActionResult CheckYourInbox()
		{
			return View();
		}

		#endregion

		#region ResetPassword

		public IActionResult ResetPassword(string email, string token)
		{
			TempData["email"] = email;
			TempData["token"] = token;

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken] // To handle internal request Only
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
		{
			if (ModelState.IsValid)
			{
				string email = TempData["email"] as string;
				string token = TempData["token"] as string;

				var user = await _userManager.FindByEmailAsync(email);
				var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);

				if (result.Succeeded)
				{
					return RedirectToAction(nameof(Login));
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}
			return View(model);
		}

		#endregion
	}
}
