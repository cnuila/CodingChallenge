using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public class LoggedTimeService : ILoggedTimeService
    {
        private readonly HttpClient httpClient;

        public LoggedTimeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<LoggedTime> AddLoggedTime(LoggedTime loggedTimeToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLoggedTime(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LoggedTime> GetLoggedTime(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<LoggedTimeDataResult> GetLoggedTimesByEmployee(int id, string start, string end, int skip, int take)
        {
            return await httpClient.GetFromJsonAsync<LoggedTimeDataResult>($"/api/loggedtimes/employee/{id}/{start}/{end}?skip={skip}&take={take}");
        }

        public Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
