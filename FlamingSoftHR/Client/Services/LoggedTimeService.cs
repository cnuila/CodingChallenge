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

        public async Task<LoggedTime> AddLoggedTime(LoggedTime loggedTimeToAdd)
        {
            var response = await httpClient.PostAsJsonAsync("/api/loggedtimes", loggedTimeToAdd);
            return await response.Content.ReadFromJsonAsync<LoggedTime>();
        }

        public async Task DeleteLoggedTime(int id)
        {
            await httpClient.DeleteAsync($"/api/loggedtimes/{id}");
        }

        public async Task<LoggedTime> GetLoggedTime(int id)
        {
            return await httpClient.GetFromJsonAsync<LoggedTime>($"/api/loggedtimes/{id}");
        }

        public async Task<LoggedTimeDataResult> GetLoggedTimesByEmployee(int id, string start, string end, int skip, int take)
        {
            return await httpClient.GetFromJsonAsync<LoggedTimeDataResult>($"/api/loggedtimes/employee/{id}/{start}/{end}?skip={skip}&take={take}");
        }

        public async Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate)
        {
            var response = await httpClient.PutAsJsonAsync($"/api/loggedtimes/{loggedTimeToUpdate.Id}", loggedTimeToUpdate);
            return await response.Content.ReadFromJsonAsync<LoggedTime>();
        }

        public async Task<TotalHours> GetHours(int id, string start, string end)
        {
            return await httpClient.GetFromJsonAsync<TotalHours>($"/api/loggedtimes/hours/{id}/{start}/{end}");
        }
    }
}
