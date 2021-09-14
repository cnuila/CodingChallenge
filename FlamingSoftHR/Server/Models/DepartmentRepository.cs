using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public DepartmentRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<Department> AddDepartment(Department departmentToAdd)
        {
            var result = await hrContext.Departments.AddAsync(departmentToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteDepartment(int id)
        {
            var result = await hrContext.Departments.FirstOrDefaultAsync(d => d.Id == id);
            if (result != null)
            {
                hrContext.Departments.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<Department> GetDepartment(int id)
        {
            return await hrContext.Departments.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await hrContext.Departments.ToListAsync();
        }

        public async Task<Department> UpdateDepartment(Department departmentToUpdate)
        {
            var result = await hrContext.Departments.FirstOrDefaultAsync(d => d.Id == departmentToUpdate.Id);
            if (result != null)
            {
                result.Name = departmentToUpdate.Name;
                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
