using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
        Task<Department> AddDepartment(Department departmentToAdd);
        Task<Department> UpdateDepartment(Department departmentToUpdate);
        Task DeleteDepartment(int id);
    }
}
