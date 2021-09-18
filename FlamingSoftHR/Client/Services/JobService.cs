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

        public Task<Job> AddJob(Job jobToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJob(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Job> GetJob(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<JobDataResult> GetJobs(int skip, int take)
        {
            return await httpClient.GetFromJsonAsync<JobDataResult>($"/api/jobs?skip={skip}&take={take}");
        }

        public Task<Job> UpdateJob(Job jobToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
