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

        public Task<LoggedTimeType> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLoggedTimeType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LoggedTimeType> GetLoggedTimeType(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LoggedTimeType>> GetLoggedTimeTypes()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<LoggedTimeType>>("/api/loggedtimetypes");
        }

        public Task<LoggedTimeType> UpdateLoggedTimeType(LoggedTimeType loggedTimeTypeToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
