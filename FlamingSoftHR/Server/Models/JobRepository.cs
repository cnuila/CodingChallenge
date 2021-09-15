using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class JobRepository : IJobRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public JobRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<Job> AddJob(Job jobToAdd)
        {
            var result = await hrContext.Job.AddAsync(jobToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteJob(int id)
        {
            var result = await hrContext.Job.FirstOrDefaultAsync(j => j.Id == id);
            if (result != null)
            {
                hrContext.Job.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<Job> GetJob(int id)
        {
            return await hrContext.Job.FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await hrContext.Job.ToListAsync();
        }

        public async Task<Job> UpdateJob(Job jobToUpdate)
        {
            var result = await hrContext.Job.FirstOrDefaultAsync(j => j.Id == jobToUpdate.Id);
            if (result != null)
            {
                result.DepartmentId = jobToUpdate.DepartmentId;
                result.Description = jobToUpdate.Description;
                result.MinSalary = jobToUpdate.MinSalary;
                result.MaxSalary = jobToUpdate.MaxSalary;

                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
