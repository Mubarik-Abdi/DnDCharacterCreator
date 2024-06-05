using System.Collections.Generic;
using System.Threading.Tasks;
using DnDCharacterCreator.Models;

namespace DnDCharacterCreator.Services
{
    public interface IStatsService
    {
        Task<IEnumerable<Stats>> GetAllStatsAsync();
        Task<Stats> GetStatsByIdAsync(int characterId);
        Task<Stats> CreateStatsAsync(Stats stats);
        Task<Stats> UpdateStatsAsync(int characterId, Stats stats);
        Task<bool> DeleteStatsAsync(int characterId);
    }
}
