using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Department> AddDepartment(Department departmentToAdd)
        {
            var response = await httpClient.PostAsJsonAsync("/api/departments", departmentToAdd);
            return await response.Content.ReadFromJsonAsync<Department>();
        }

        public async Task DeleteDepartment(int id)
        {
            await httpClient.DeleteAsync($"/api/departments/{id}");
        }

        public async Task<Department> GetDepartment(int id)
        {
            return await httpClient.GetFromJsonAsync<Department>($"/api/departments/{id}");

        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Department>>("/api/departments");
        }

        public async Task<Department> UpdateDepartment(Department departmentToUpdate)
        {
            var response = await httpClient.PutAsJsonAsync($"/api/departments/{departmentToUpdate.Id}", departmentToUpdate);
            return await response.Content.ReadFromJsonAsync<Department>();
        }
    }
}
