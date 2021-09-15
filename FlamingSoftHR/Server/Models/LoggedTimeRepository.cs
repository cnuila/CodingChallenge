using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeRepository : ILoggedTimeRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public LoggedTimeRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<LoggedTime> AddLoggedTime(LoggedTime loggedTimeToAdd)
        {
            var result = await hrContext.LoggedTime.AddAsync(loggedTimeToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteLoggedTime(int id)
        {
            var result = await hrContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == id);
            if (result != null)
            {
                hrContext.LoggedTime.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<LoggedTime> GetLoggedTime(int id)
        {
            return await hrContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<LoggedTime>> GetLoggedTimes()
        {
            return await hrContext.LoggedTime.ToListAsync();
        }

        public async Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate)
        {
            var result = await hrContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == loggedTimeToUpdate.Id);
            if (result != null)
            {
                result.DateLogged = loggedTimeToUpdate.DateLogged;
                result.Hours = loggedTimeToUpdate.Hours;
                result.LogTypeId = loggedTimeToUpdate.LogTypeId;
                result.WeekNumber = loggedTimeToUpdate.WeekNumber;

                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
