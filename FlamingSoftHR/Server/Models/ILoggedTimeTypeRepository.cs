using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface ILoggedTimeTypeRepository
    {
        Task<IEnumerable<LoggedTimeType>> GetLoggedTimeTypes();
        Task<LoggedTimeType> GetLoggedTimeType(int id);
        Task<LoggedTimeType> AddLoggedTimeType(LoggedTimeType loggedTimeTypeToAdd);
        Task<LoggedTimeType> UpdateLoggedTimeType(LoggedTimeType loggedTimeTypeToUpdate);
        Task DeleteLoggedTimeType(int id);
    }
}
