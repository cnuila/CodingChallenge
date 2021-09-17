using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeTypeRepository : ILoggedTimeTypeRepository
    {
        private readonly ApplicationDbContext applicationDBContext;

        public LoggedTimeTypeRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task<LoggedTimeType> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd)
        {
            var result = await applicationDBContext.LoggedTimeType.AddAsync(loggedTimeTypeToAdd);
            await applicationDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteLoggedTimeType(int id)
        {
            var result = await applicationDBContext.LoggedTimeType.FirstOrDefaultAsync(l => l.Id == id);
            if (result != null)
            {
                applicationDBContext.LoggedTimeType.Remove(result);
                await applicationDBContext.SaveChangesAsync();
            }
        }

        public async Task<LoggedTimeType> GetLoggedTimeType(int id)
        {
            return await applicationDBContext.LoggedTimeType.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<LoggedTimeType>> GetLoggedTimeTypes()
        {
            return await applicationDBContext.LoggedTimeType.ToListAsync();
        }

        public async Task<LoggedTimeType> UpdateLoggedTimeType(LoggedTimeType loggedTimeTypeToUpdate)
        {
            var result = await applicationDBContext.LoggedTimeType.FirstOrDefaultAsync(l => l.Id == loggedTimeTypeToUpdate.Id);
            if (result != null)
            {
                result.Description = loggedTimeTypeToUpdate.Description;
                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
