using Infrastructure.Abstract;
using Infrastructure.RepoModels;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD_Employee_NTier.Controllers
{
    public class MyEmployeeController : Controller
    {
        IEmployeeInfoRepository _repo = new EmployeeInfoRepository();
        public IActionResult Index()
        {
            List<Employee> lstEmp = _repo.GetAllEmployees();

            return View(lstEmp);
        }

        public IActionResult Create()
        {
            return View(new Employee()); // Create a new empty Employee object for the form
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repo.SaveEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee); // Return the form with validation errors
        }
      
        public IActionResult Edit(int employeeCode)
        {
            var employee = _repo.GetEmployeeById(employeeCode);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(int employeeCode, Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateEmployee(employeeCode, employee);
                return RedirectToAction("Index");
            }

            return View(employee); // Return the form with validation errors
        }
        public IActionResult Delete(int employeeCode)
        {
            var employee = _repo.GetEmployeeById(employeeCode);
            if (employee == null)
            {
                return NotFound();
            }
            return RedirectToAction("Index");

        }
    }

}
