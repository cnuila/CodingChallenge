using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface IJobRepository
    {
        Task<JobDataResult> GetJobs(int skip, int take);
        Task<Job> GetJob(int id);
        Task<Job> AddJob(Job jobToAdd);
        Task<Job> UpdateJob(Job jobToUpdate);
        Task DeleteJob(int id);
    }
}
