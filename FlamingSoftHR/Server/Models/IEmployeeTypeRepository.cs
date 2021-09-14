using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface IEmployeeTypeRepository
    {
        Task<IEnumerable<EmployeeType>> GetEmployeeTypes();
        Task<EmployeeType> GetEmployeeType(int id);
        Task<EmployeeType> AddEmployeeType(EmployeeType employeeTypeToAdd);
        Task<EmployeeType> UpdateEmployeeType(EmployeeType employeeTypeToUpdate);
        Task DeleteEmployeeType(int id);
    }
}
