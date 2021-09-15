using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public EmployeeRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<Employee> AddEmployee(Employee employeeToAdd)
        {
            var result = await hrContext.Employee.AddAsync(employeeToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(int id)
        {
            var result = await hrContext.Employee.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                hrContext.Employee.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await hrContext.Employee.FirstOrDefaultAsync(e => e.Id == id);
            
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await hrContext.Employee.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employeeToUpdate)
        {
            var result = await hrContext.Employee.FirstOrDefaultAsync(e => e.Id == employeeToUpdate.Id);
            if (result != null)
            {
                result.FirstName = employeeToUpdate.FirstName;
                result.LastName = employeeToUpdate.LastName;
                result.MiddleName = employeeToUpdate.MiddleName;
                result.EmployeeTypeId = employeeToUpdate.EmployeeTypeId;
                result.Salary = employeeToUpdate.Salary;
                result.JobId = employeeToUpdate.JobId;

                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
