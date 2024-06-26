﻿using AutoMapper;
using DALDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PLDemoe.Helpers;
using PLDemoe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLDemoe.Controllers
{
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly IMapper _mapper;

		public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMapper mapper)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index(string email)
		{
			if (string.IsNullOrEmpty(email))
			{
				var users = await _userManager.Users.Select(U => new UserViewModel()
				{
					Id = U.Id,
					FName = U.FName,
					LName = U.LName,
					Email = U.Email,
					PhoneNumber = U.PhoneNumber,
					Roles = _userManager.GetRolesAsync(U).Result
				}).ToListAsync();
				return View(users);
			}
			else
			{
				var user = await _userManager.FindByEmailAsync(email);

				var MappedUser = new UserViewModel()
				{
					Id = user.Id,
					FName = user.FName,
					LName = user.LName,
					Email = user.Email,
					PhoneNumber = user.PhoneNumber,
					Roles = _userManager.GetRolesAsync(user).Result
				};
				return View(new List<UserViewModel>() { MappedUser });
			}
		}

		public async Task<IActionResult> Details(string id, string ViewName = "Details")
		{
			if (id is null)               
				return BadRequest(); // 400

			var user = await _userManager.FindByIdAsync(id);

			if (user == null)
				return NotFound(); // 404
			var Mappeduser = _mapper.Map<ApplicationUser, UserViewModel>(user);

			return View(ViewName, Mappeduser);
		}

		public async Task<IActionResult> Edit(string id)
		{
			return await Details(id, "Edit");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(string id, UserViewModel updatedUser)
		{

			if (id != updatedUser.Id)
			{
				return BadRequest();
			}
			if (ModelState.IsValid)
			{
				try
				{
					//var MappedEmp = _mapper.Map<UserViewModel, ApplicationUser>(updatedUser);


					var user = await _userManager.FindByIdAsync(id);
					user.FName = updatedUser.FName;
					user.LName = updatedUser.LName;
					user.PhoneNumber = updatedUser.PhoneNumber;
					//user.Email = updatedUser.Email;
					//user.SecurityStamp = Guid.NewGuid().ToString();

					await _userManager.UpdateAsync(user);

					return RedirectToAction(nameof(Index));
				}
				catch (System.Exception EX)
				{
					ModelState.AddModelError(string.Empty, EX.Message);
				}

			}
			return View(updatedUser);
		}

		public async Task<IActionResult> Delete(string id)
		{
			return await Details(id, "Delete");
		}

		//[HttpPost]
		//public async Task<IActionResult> Delete(UserViewModel deleteduser)
		//{
		//	try
		//	{
		//		var mappeduser = _mapper.Map<UserViewModel, ApplicationUser>(deleteduser);
		//		await _userManager.DeleteAsync(mappeduser);


		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch (System.Exception EX)
		//	{
		//		ModelState.AddModelError(string.Empty, EX.Message);
		//		return View(deleteduser);
		//	}
		//}

		[HttpPost(Name = "Delete")]
		public async Task<IActionResult> ConfirmDelete(string id)
		{
			try
			{
				var user = await _userManager.FindByIdAsync(id);
				await _userManager.DeleteAsync(user);


				return RedirectToAction(nameof(Index));
			}
			catch (System.Exception EX)
			{
				ModelState.AddModelError(string.Empty, EX.Message);
				return RedirectToAction("Error", "Home");
			}
		}
	}
}
