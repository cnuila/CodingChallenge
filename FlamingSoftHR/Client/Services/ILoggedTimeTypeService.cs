using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public interface ILoggedTimeTypeService
    {
        Task<IEnumerable<LoggedTimeType>> GetLoggedTimeTypes();
        Task<LoggedTimeType> GetLoggedTimeType(int id);
        Task<LoggedTimeType> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd);
        Task<LoggedTimeType> UpdateLoggedTimeType(LoggedTimeType loggedTimeTypeToUpdate);
        Task DeleteLoggedTimeType(int id);
    }
}
