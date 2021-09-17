using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeRepository : ILoggedTimeRepository
    {
        private readonly ApplicationDbContext applicationDBContext;

        public LoggedTimeRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task<LoggedTime> AddLoggedTime(LoggedTime loggedTimeToAdd)
        {
            var result = await applicationDBContext.LoggedTime.AddAsync(loggedTimeToAdd);
            await applicationDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteLoggedTime(int id)
        {
            var result = await applicationDBContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == id);
            if (result != null)
            {
                applicationDBContext.LoggedTime.Remove(result);
                await applicationDBContext.SaveChangesAsync();
            }
        }

        public async Task<LoggedTime> GetLoggedTime(int id)
        {
            return await applicationDBContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<LoggedTime>> GetLoggedTimes()
        {
            return await applicationDBContext.LoggedTime.ToListAsync();
        }

        public async Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate)
        {
            var result = await applicationDBContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == loggedTimeToUpdate.Id);
            if (result != null)
            {
                result.DateLogged = loggedTimeToUpdate.DateLogged;
                result.Hours = loggedTimeToUpdate.Hours;
                result.LogTypeId = loggedTimeToUpdate.LogTypeId;
                result.WeekNumber = loggedTimeToUpdate.WeekNumber;

                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
