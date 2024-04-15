using Infrastructure.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstract
{
    public interface IEmployeeInfoRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeCode);
        void SaveEmployee(Employee employee);
        void UpdateEmployee(int employeeCode, Employee employee);
    }
}
