using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeTypeRepository : ILoggedTimeTypeRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public LoggedTimeTypeRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<LoggedTimeType> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd)
        {
            var result = await hrContext.LoggedTimeType.AddAsync(loggedTimeTypeToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteLoggedTimeType(int id)
        {
            var result = await hrContext.LoggedTimeType.FirstOrDefaultAsync(l => l.Id == id);
            if (result != null)
            {
                hrContext.LoggedTimeType.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<LoggedTimeType> GetLoggedTimeType(int id)
        {
            return await hrContext.LoggedTimeType.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<LoggedTimeType>> GetLoggedTimeTypes()
        {
            return await hrContext.LoggedTimeType.ToListAsync();
        }

        public async Task<LoggedTimeType> UpdateLoggedTimeType(LoggedTimeType loggedTimeTypeToUpdate)
        {
            var result = await hrContext.LoggedTimeType.FirstOrDefaultAsync(l => l.Id == loggedTimeTypeToUpdate.Id);
            if (result != null)
            {
                result.Description = loggedTimeTypeToUpdate.Description;
                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
