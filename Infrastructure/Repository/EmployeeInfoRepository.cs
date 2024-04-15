using Infrastructure.Abstract;
using Infrastructure.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
     public class EmployeeInfoRepository : IEmployeeInfoRepository
    {
        public EmployeeInfoContext _context = new EmployeeInfoContext();       

        public List<Employee> GetAllEmployees()
        {
            return _context.EmployeeDetails.ToList();
        }

        public Employee GetEmployeeById(int employeeCode)
        {
            return _context.EmployeeDetails.Find(employeeCode);
        }

        public void SaveEmployee(Employee employee)
        {
            _context.EmployeeDetails.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(int employeeCode, Employee employee)
        {
            var existingEmployee = _context.EmployeeDetails.Find(employeeCode);
            if (existingEmployee != null)
            {
                // Update relevant employee properties
                existingEmployee.EmployeeName = employee.EmployeeName;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Department = employee.Department;
                existingEmployee.Designation = employee.Designation;
                existingEmployee.BasicSalary = employee.BasicSalary;
                _context.SaveChanges();
            }
        }

    }
}
