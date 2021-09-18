using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public interface ILoggedTimeService
    {
        Task<LoggedTimeDataResult> GetLoggedTimesByEmployee(int id, string start, string end, int skip, int take);
        Task<LoggedTime> GetLoggedTime(int id);
        Task<LoggedTime> AddLoggedTime(LoggedTime loggedTimeToAdd);
        Task<LoggedTime> UpdateLoggedTime(LoggedTime loggedTimeToUpdate);
        Task DeleteLoggedTime(int id);
    }
}
