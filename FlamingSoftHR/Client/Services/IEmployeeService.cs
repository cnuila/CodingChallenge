using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public interface IEmployeeService { 

        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> AddEmployee(Employee employeeToAdd);
        Task<Employee> UpdateEmployee(Employee employeeToUpdate);
        Task DeleteEmployee(int id);
    }
}
