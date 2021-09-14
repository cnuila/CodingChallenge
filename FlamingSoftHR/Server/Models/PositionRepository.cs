using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server.Models
{
    public class PositionRepository : IPositionRepository
    {
        private readonly FlamingSoftHRContext hrContext;

        public PositionRepository(FlamingSoftHRContext hrContext)
        {
            this.hrContext = hrContext;
        }

        public async Task<Position> AddPosition(Position positionToAdd)
        {
            var result = await hrContext.Positions.AddAsync(positionToAdd);
            await hrContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeletePosition(int id)
        {
            var result = await hrContext.Positions.FirstOrDefaultAsync(p => p.Id == id);
            if (result != null)
            {
                hrContext.Positions.Remove(result);
                await hrContext.SaveChangesAsync();
            }
        }

        public async Task<Position> GetPosition(int id)
        {
            return await hrContext.Positions.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Position>> GetPositions()
        {
            return await hrContext.Positions.ToListAsync();
        }

        public async Task<Position> UpdatePosition(Position positionToUpdate)
        {
            var result = await hrContext.Positions.FirstOrDefaultAsync(p => p.Id == positionToUpdate.Id);
            if (result != null)
            {
                result.DepartmentId = positionToUpdate.DepartmentId;
                result.Description = positionToUpdate.Description;
                result.Salary = positionToUpdate.Salary;
                result.EmployeeId = positionToUpdate.EmployeeId;

                await hrContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
