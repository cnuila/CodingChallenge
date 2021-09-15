using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public EmployeeTypeRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<EmployeeType> AddEmployeeType(EmployeeType employeeTypeToAdd)
        {
            var result = await hrContext.EmployeeType.AddAsync(employeeTypeToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployeeType(int id)
        {
            var result = await hrContext.EmployeeType.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                hrContext.EmployeeType.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<EmployeeType> GetEmployeeType(int id)
        {
            return await hrContext.EmployeeType.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<EmployeeType>> GetEmployeeTypes()
        {
            return await hrContext.EmployeeType.ToListAsync();
        }

        public async Task<EmployeeType> UpdateEmployeeType(EmployeeType employeeTypeToUpdate)
        {
            var result = await hrContext.EmployeeType.FirstOrDefaultAsync(e => e.Id == employeeTypeToUpdate.Id);
            if (result != null)
            {
                result.Description = employeeTypeToUpdate.Description;
                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
