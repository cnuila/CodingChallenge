using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext applicationDBContext;

        public DepartmentRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task<Department> AddDepartment(Department departmentToAdd)
        {
            var result = await applicationDBContext.Department.AddAsync(departmentToAdd);
            await applicationDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteDepartment(int id)
        {
            var result = await applicationDBContext.Department.FirstOrDefaultAsync(d => d.Id == id);
            if (result != null)
            {
                applicationDBContext.Department.Remove(result);
                await applicationDBContext.SaveChangesAsync();
            }
        }

        public async Task<Department> GetDepartment(int id)
        {
            return await applicationDBContext.Department.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await applicationDBContext.Department.ToListAsync();
        }

        public async Task<Department> UpdateDepartment(Department departmentToUpdate)
        {
            var result = await applicationDBContext.Department.FirstOrDefaultAsync(d => d.Id == departmentToUpdate.Id);
            if (result != null)
            {
                result.Name = departmentToUpdate.Name;
                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
