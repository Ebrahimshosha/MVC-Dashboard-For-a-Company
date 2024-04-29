using AutoMapper;
using BLLDemo.Interfaces;
using BLLDemo.Reposatories;
using DALDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PLDemoe.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PLDemoe.Controllers
{
	// There are Two Relatinship 
	// 1. Inheritance : DepartmentController is  a Controller
	// 2. Association : DepartmentController has a Controller
	// Association must be [Composition][Not Null] Not Aggreagation in this case
	// because No action in DepartmentController  dosen't need DepartmentRepository 
	// because No action in DepartmentController  → _departmentRepo =	Null
	[Authorize]
	public class DepartmentController : Controller
	{
		//private readonly IDepartmentRepository _departmentRepo;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public DepartmentController(IUnitOfWork unitOfWork,/*IDepartmentRepository departmentRepo,*/ IMapper mapper)

		/// Ask CLR For Creating an Object From Class implementing Interface "IDepartmentRepository",
		/// Then U must Allow Dependency Injection For IDepartmentRepository

		{
			//_departmentRepo = departmentRepo;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var Dep = await _unitOfWork.DepartmentRepository.GetAll();
			var MappedDep = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(Dep);
			return View(MappedDep);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
		{
			if (ModelState.IsValid) // Server Side Validation
			{
				var MappedDep = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
				await _unitOfWork.DepartmentRepository.Add(MappedDep);
				var count = await _unitOfWork.Complete();
				if (count > 0)
				{
					// TempData is used to pass data between two consecutive requests.
					// TempData only works during the current and subsequent request.
					TempData["Message"] = "Department is created successfully";
					return RedirectToAction(nameof(Index));
				}
			}
			return View(departmentVM);
		}

		public async Task<IActionResult> Details(int? id, string ViewName = "Details")
		{
			if (!id.HasValue)               // == if (id is null)
				return BadRequest(); //  client side Error 400

			var dep = await _unitOfWork.DepartmentRepository.Get(id.Value);

			if (dep == null)
				return NotFound(); // 404
			var MappedDep = _mapper.Map<Department, DepartmentViewModel>(dep);

			return View(ViewName, MappedDep);
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (!id.HasValue)               // == if (id is null)
				return BadRequest(); // 400

			var dep = await _unitOfWork.DepartmentRepository.Get(id.Value);

			if (dep == null)
				return NotFound(); // 404

			var MappedDep = _mapper.Map<Department, DepartmentViewModel>(dep);

			return View(MappedDep);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit([FromRoute] int id, DepartmentViewModel departmentVM)
		{

			if (id != departmentVM.Id)
			{
				return BadRequest();
			}
			if (ModelState.IsValid)
			{
				try
				{
					var MappedDep = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
					_unitOfWork.DepartmentRepository.Update(MappedDep);
					await _unitOfWork.Complete();
					return RedirectToAction(nameof(Index));
				}
				catch (System.Exception EX)
				{
					ModelState.AddModelError(string.Empty, EX.Message);
				}
			}
			return View(departmentVM);
		}

		public async Task<IActionResult> Delete(int? id)
		{
			return await Details(id, "Delete");
		}
		[HttpPost]
		public IActionResult Delete(DepartmentViewModel departmentVM)
		{
			try
			{
				var MappedDep = _mapper.Map<DepartmentViewModel,Department>(departmentVM);
				_unitOfWork.DepartmentRepository.Delete(MappedDep);
				TempData["Message"] = "Department is Deleted successfully";
				_unitOfWork.Complete();
				return RedirectToAction(nameof(Index));
			}
			catch (System.Exception EX)
			{
				ModelState.AddModelError(string.Empty, EX.Message);
				return View(departmentVM);
			}
		}
	}
}
