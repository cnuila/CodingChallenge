using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext applicationDBContext;

        public EmployeeRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task<Employee> AddEmployee(Employee employeeToAdd)
        {
            if (employeeToAdd.Job != null)
            {
                applicationDBContext.Entry(employeeToAdd.Job).State = EntityState.Unchanged;
            }

            var result = await applicationDBContext.Employee.AddAsync(employeeToAdd);
            await applicationDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(int id)
        {
            var result = await applicationDBContext.Employee.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                applicationDBContext.Employee.Remove(result);
                await applicationDBContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployeeByUserId(string userId)
        {
            return await applicationDBContext.Employee.Include(e => e.Job.Department).FirstOrDefaultAsync(e => e.UserId == userId);
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await applicationDBContext.Employee.Include(e => e.Job.Department).FirstOrDefaultAsync(e => e.Id == id);
            
        }

        public async Task<EmployeeDataResult> GetEmployees(int skip = 0, int take = 10)
        {
            EmployeeDataResult result = new()
            {
                Employees = applicationDBContext.Employee.Include(e => e.Job.Department).Skip(skip).Take(take),
                Count = await applicationDBContext.Employee.CountAsync()
            };
            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee employeeToUpdate)
        {
            var result = await applicationDBContext.Employee.FirstOrDefaultAsync(e => e.Id == employeeToUpdate.Id);
            if (result != null)
            {
                result.FirstName = employeeToUpdate.FirstName;
                result.LastName = employeeToUpdate.LastName;
                result.MiddleName = employeeToUpdate.MiddleName;
                result.EmployeeTypeId = employeeToUpdate.EmployeeTypeId;
                result.Salary = employeeToUpdate.Salary;
                result.JobId = employeeToUpdate.JobId;

                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
