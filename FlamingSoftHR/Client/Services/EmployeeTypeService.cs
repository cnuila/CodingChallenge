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

        public Task<EmployeeType> AddEmployeeType(EmployeeType employeeTypeToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeType> GetEmployeeType(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeType>> GetEmployeeTypes()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<EmployeeType>>("/api/employeetypes");
        }

        public Task<EmployeeType> UpdateEmployeeType(EmployeeType employeeTypeToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
