using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        private readonly ApplicationDbContext applicationDBContext;

        public EmployeeTypeRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task<EmployeeType> AddEmployeeType(EmployeeType employeeTypeToAdd)
        {
            var result = await applicationDBContext.EmployeeType.AddAsync(employeeTypeToAdd);
            await applicationDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployeeType(int id)
        {
            var result = await applicationDBContext.EmployeeType.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                applicationDBContext.EmployeeType.Remove(result);
                await applicationDBContext.SaveChangesAsync();
            }
        }

        public async Task<EmployeeType> GetEmployeeType(int id)
        {
            return await applicationDBContext.EmployeeType.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<EmployeeType>> GetEmployeeTypes()
        {
            return await applicationDBContext.EmployeeType.ToListAsync();
        }

        public async Task<EmployeeType> UpdateEmployeeType(EmployeeType employeeTypeToUpdate)
        {
            var result = await applicationDBContext.EmployeeType.FirstOrDefaultAsync(e => e.Id == employeeTypeToUpdate.Id);
            if (result != null)
            {
                result.Description = employeeTypeToUpdate.Description;
                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
