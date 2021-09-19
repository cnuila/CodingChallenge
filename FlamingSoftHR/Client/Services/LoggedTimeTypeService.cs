using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public class LoggedTimeTypeService : ILoggedTimeTypeService
    {
        private readonly HttpClient httpClient;

        public LoggedTimeTypeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<LoggedTimeType> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd)
        {
            var response = await httpClient.PostAsJsonAsync("/api/loggedtimetypes", loggedTimeTypeToAdd);
            return await response.Content.ReadFromJsonAsync<LoggedTimeType>();
        }

        public async Task DeleteLoggedTimeType(int id)
        {
            await httpClient.DeleteAsync($"/api/loggedtimetypes/{id}");
        }

        public async Task<LoggedTimeType> GetLoggedTimeType(int id)
        {
            return await httpClient.GetFromJsonAsync<LoggedTimeType>($"/api/loggedtimetypes/{id}");
        }

        public async Task<IEnumerable<LoggedTimeType>> GetLoggedTimeTypes()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<LoggedTimeType>>("/api/loggedtimetypes");
        }

        public async Task<LoggedTimeType> UpdateLoggedTimeType(LoggedTimeType loggedTimeTypeToUpdate)
        {
            var response = await httpClient.PutAsJsonAsync($"/api/loggedtimetypes/{loggedTimeTypeToUpdate.Id}", loggedTimeTypeToUpdate);
            return await response.Content.ReadFromJsonAsync<LoggedTimeType>();
        }
    }
}
