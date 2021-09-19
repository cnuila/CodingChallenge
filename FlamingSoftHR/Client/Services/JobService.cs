using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public class JobService : IJobService
    {
        private readonly HttpClient httpClient;

        public JobService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Job> AddJob(Job jobToAdd)
        {
            var response = await httpClient.PostAsJsonAsync("/api/jobs", jobToAdd);
            return await response.Content.ReadFromJsonAsync<Job>();
        }

        public async Task DeleteJob(int id)
        {
            await httpClient.DeleteAsync($"/api/jobs/{id}");
        }

        public async Task<Job> GetJob(int id)
        {
            return await httpClient.GetFromJsonAsync<Job>($"/api/jobs/{id}");
        }

        public async Task<JobDataResult> GetJobs(int skip, int take)
        {
            return await httpClient.GetFromJsonAsync<JobDataResult>($"/api/jobs?skip={skip}&take={take}");
        }

        public async Task<IEnumerable<Job>> GetJobsByDepartment(int id)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Job>>($"/api/jobs/department/{id}");
        }

        public async Task<Job> UpdateJob(Job jobToUpdate)
        {
            var response = await httpClient.PutAsJsonAsync($"/api/jobs/{jobToUpdate.Id}", jobToUpdate);
            return await response.Content.ReadFromJsonAsync<Job>();
        }
    }
}
