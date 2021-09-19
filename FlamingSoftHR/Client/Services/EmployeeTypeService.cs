using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public class EmployeeTypeService : IEmployeeTypeService
    {
        private readonly HttpClient httpClient;

        public EmployeeTypeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<EmployeeType> AddEmployeeType(EmployeeType employeeTypeToAdd)
        {
            var response = await httpClient.PostAsJsonAsync("/api/employeetypes", employeeTypeToAdd);
            return await response.Content.ReadFromJsonAsync<EmployeeType>();
        }

        public async Task DeleteEmployeeType(int id)
        {
            await httpClient.DeleteAsync($"/api/employeetypes/{id}");
        }

        public async Task<EmployeeType> GetEmployeeType(int id)
        {
            return await httpClient.GetFromJsonAsync<EmployeeType>($"/api/employeetypes/{id}");
        }

        public async Task<IEnumerable<EmployeeType>> GetEmployeeTypes()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<EmployeeType>>("/api/employeetypes");
        }

        public async Task<EmployeeType> UpdateEmployeeType(EmployeeType employeeTypeToUpdate)
        {
            var response = await httpClient.PutAsJsonAsync($"/api/employeetypes/{employeeTypeToUpdate.Id}", employeeTypeToUpdate);
            return await response.Content.ReadFromJsonAsync<EmployeeType>();
        }
    }
}
