using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Employee> AddEmployee(Employee employeeToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDataResult> GetEmployees(int skip, int take)
        {
            return await httpClient.GetFromJsonAsync<EmployeeDataResult>($"/api/employees?skip={skip}&take={take}");
        }

        public Task<Employee> UpdateEmployee(Employee employeeToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
