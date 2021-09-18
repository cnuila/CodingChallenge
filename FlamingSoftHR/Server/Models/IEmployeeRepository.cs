using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeByUserId(string userId);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> AddEmployee(Employee employeeToAdd);
        Task<Employee> UpdateEmployee(Employee employeeToUpdate);
        Task DeleteEmployee(int id);
    }
}
