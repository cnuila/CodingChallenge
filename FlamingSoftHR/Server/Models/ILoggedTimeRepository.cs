using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface ILoggedTimeRepository
    {
        Task<LoggedTimeDataResult> GetLoggedTimesByEmployee(int employeeId, string start, string end, int skip, int take);
        Task<LoggedTime> GetLoggedTime(int id);
        Task<LoggedTime> AddLoggedTime(LoggedTime loggedTimeToAdd);
        Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate);
        Task DeleteLoggedTime(int id);
    }
}
