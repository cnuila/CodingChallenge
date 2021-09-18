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

        public Task<Department> AddDepartment(Department departmentToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Department>>("/api/departments");
        }

        public Task<Department> UpdateDepartment(Department departmentToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
