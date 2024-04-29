using AutoMapper;
using BLLDemo;
using BLLDemo.Interfaces;
using BLLDemo.Reposatories;
using DALDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PLDemoe.Helpers;
using PLDemoe.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PLDemoe.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;

		//private readonly IEmployeeRopository _employeeRepository;
		//private readonly IDepartmentRepository _departmentRepository;
		private readonly IMapper _mapper;

		public EmployeeController(IUnitOfWork unitOfWork,
			/*IEmployeeRopository employeeRepository, IDepartmentRepository departmentRepository,*/ IMapper mapper)

		/// Ask CLR For Creating an Object From Class implementing Interface "IDepartmentRepository",
		/// Then U must Allow Dependency Injection For IDepartmentRepository

		{
			_unitOfWork = unitOfWork;
			//_employeeRepository = employeeRepository;
			//_departmentRepository = departmentRepository;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index(string SearchValue)
		{
			/// Binding is one way Binding at MVC

			// 1. ViewData is a Dictionary Object (introduced in Asp.Net FrameWork 3.5)
			// => It helps Us to Transfer Data from Controller [Action] To View
			ViewData["Message"] = "Hello ViewData";

			// 2. ViewBag is a Dynamic Property (introduced in Asp.Net FrameWork 4.0 based on Dynamic Keyword)
			// => It helps Us to Transfer Data from Controller [Action] To View
			ViewBag.Message = "Hello ViewBag";

			// 3. TempData in Create

			IEnumerable<Employee> Emps;

			if (string.IsNullOrEmpty(SearchValue))
				Emps = await _unitOfWork.EmployeeRopository.GetAll();
			else
				Emps = _unitOfWork.EmployeeRopository.SearchEmployeesByName(SearchValue);

			var MappedEmployee = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(Emps);

			return View(MappedEmployee);
		}

		[HttpGet]
		public IActionResult Create()
		{
			// ViewBag.Departments = _departmentRepository.GetAll();
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
		{
			if (ModelState.IsValid) // Server Side Validation
			{
				employeeVM.ImageName = await DocumentSettings.UploadFileAsync(employeeVM.Image, "Images");
				var MappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
				await _unitOfWork.EmployeeRopository.Add(MappedEmp);
				var count = await _unitOfWork.Complete();
				if (count > 0) // To Check if Employee is created or not
				{
					// TempData is used to pass data between two consecutive requests.
					// TempData only works during the current and subsequent request.
					TempData["Message"] = "Employee is created successfully";
					return RedirectToAction(nameof(Index));
				}
			}
			return View(employeeVM);
		}

		public async Task<IActionResult> Details(int? id, string ViewName = "Details")
		{
			if (!id.HasValue)               // == if (id is null)
				return BadRequest(); // 400

			var Emp = await _unitOfWork.EmployeeRopository.Get(id.Value);

			if (Emp == null)
				return NotFound(); // 404
			var MappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(Emp);

			return View(ViewName, MappedEmployee);
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (!id.HasValue)               // == if (id is null)
				return BadRequest(); // 400

			var Emp = await _unitOfWork.EmployeeRopository.Get(id.Value);

			if (Emp == null)
				return NotFound(); // 404
			var MappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(Emp);
			return View(MappedEmployee);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel employeeVM)
		{

			if (id != employeeVM.Id)
			{
				return BadRequest();
			}
			if (ModelState.IsValid)
			{
				try
				{
					if (employeeVM.Image is not null)
					{
						employeeVM.ImageName = await DocumentSettings.UploadFileAsync(employeeVM.Image, "Images");
					}
					var MappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
					_unitOfWork.EmployeeRopository.Update(MappedEmp);
					await _unitOfWork.Complete();
					return RedirectToAction(nameof(Index));
				}
				catch (System.Exception EX)
				{
					ModelState.AddModelError(string.Empty, EX.Message);
				}

			}
			return View(employeeVM);
		}

		public async Task<IActionResult> Delete(int? id)
		{
			return await Details(id, "Delete");
		}
		[HttpPost]
		public async Task<IActionResult> Delete(EmployeeViewModel employeeVM)
		{
			try
			{
				var MappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
				_unitOfWork.EmployeeRopository.Delete(MappedEmp);
				TempData["Message"] = "Employee is created successfully";
				var count = await _unitOfWork.Complete();
				if (count > 0)
					DocumentSettings.DeleteFile(employeeVM.ImageName, "Images");

				return RedirectToAction(nameof(Index));
			}
			catch (System.Exception EX)
			{
				ModelState.AddModelError(string.Empty, EX.Message);
				return View(employeeVM);
			}
		}
	}
}
