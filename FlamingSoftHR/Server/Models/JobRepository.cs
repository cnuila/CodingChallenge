using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplicationDbContext applicationDBContext;

        public JobRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task<Job> AddJob(Job jobToAdd)
        {
            var result = await applicationDBContext.Job.AddAsync(jobToAdd);
            await applicationDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteJob(int id)
        {
            var result = await applicationDBContext.Job.FirstOrDefaultAsync(j => j.Id == id);
            if (result != null)
            {
                applicationDBContext.Job.Remove(result);
                await applicationDBContext.SaveChangesAsync();
            }
        }

        public async Task<Job> GetJob(int id)
        {
            return await applicationDBContext.Job.FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<JobDataResult> GetJobs(int skip = 0, int take = 10)
        {
            JobDataResult result = new()
            {
                Jobs = applicationDBContext.Job.Skip(skip).Take(take),
                Count = await applicationDBContext.Job.CountAsync()
            };
            return result;
        }

        public async Task<Job> UpdateJob(Job jobToUpdate)
        {
            var result = await applicationDBContext.Job.FirstOrDefaultAsync(j => j.Id == jobToUpdate.Id);
            if (result != null)
            {
                result.DepartmentId = jobToUpdate.DepartmentId;
                result.Description = jobToUpdate.Description;
                result.MinSalary = jobToUpdate.MinSalary;
                result.MaxSalary = jobToUpdate.MaxSalary;

                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
