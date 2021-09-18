using System;
using System.Collections.Generic;
using System.Linq;
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
            if (loggedTimeToAdd.LoggedTimeType != null)
            {
                applicationDBContext.Entry(loggedTimeToAdd.LoggedTimeType).State = EntityState.Unchanged;
            }

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
            return await applicationDBContext.LoggedTime.Include(l => l.LoggedTimeType).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<LoggedTimeDataResult> GetLoggedTimesByEmployee(int employeeId, int skip = 0, int take = 10)
        {
            IQueryable<LoggedTime> query = applicationDBContext.LoggedTime.Include(l => l.LoggedTimeType).Where(l => l.EmployeeId == employeeId).Skip(skip).Take(take);
            LoggedTimeDataResult result = new()
            {
                LoggedTimes = await query.ToListAsync(),
                Count = await query.CountAsync()
            };
            return result;
        }

        public async Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate)
        {
            var result = await applicationDBContext.LoggedTime.FirstOrDefaultAsync(l => l.Id == loggedTimeToUpdate.Id);
            if (result != null)
            {
                result.DateLogged = loggedTimeToUpdate.DateLogged;
                result.Hours = loggedTimeToUpdate.Hours;
                result.LoggedTimeTypeId = loggedTimeToUpdate.LoggedTimeTypeId;
                result.WeekNumber = loggedTimeToUpdate.WeekNumber;

                await applicationDBContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
