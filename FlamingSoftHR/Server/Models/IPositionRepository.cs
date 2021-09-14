using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Server.Models
{
    public interface IPositionRepository
    {
        Task<IEnumerable<Position>> GetPositions();
        Task<Position> GetPosition(int id);
        Task<Position> AddPosition(Position positionToAdd);
        Task<Position> UpdatePosition(Position positionToUpdate);
        Task DeletePosition(int id);
    }
}
