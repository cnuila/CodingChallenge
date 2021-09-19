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

        public async Task<Employee> AddEmployee(Employee employeeToAdd)
        {
            var response = await httpClient.PostAsJsonAsync("/api/employees", employeeToAdd);
            return await response.Content.ReadFromJsonAsync<Employee>();
        }

        public async Task DeleteEmployee(int id)
        {
            await httpClient.DeleteAsync($"/api/employees/{id}");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"/api/employees/{id}");
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"/api/employees/{email}");
        }

        public async Task<EmployeeDataResult> GetEmployees(int skip, int take)
        {
            return await httpClient.GetFromJsonAsync<EmployeeDataResult>($"/api/employees?skip={skip}&take={take}");
        }

        public async Task<Employee> UpdateEmployee(Employee employeeToUpdate)
        {
            var response = await httpClient.PutAsJsonAsync($"/api/employees/{employeeToUpdate.Id}", employeeToUpdate);
            return await response.Content.ReadFromJsonAsync<Employee>();
        }
    }
}
