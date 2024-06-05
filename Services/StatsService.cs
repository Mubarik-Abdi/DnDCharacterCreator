using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDCharacterCreator.Models;
using Microsoft.EntityFrameworkCore;
using DnDCharacterCreator.Infrastructure.Data;

namespace DnDCharacterCreator.Services
{
    public class StatsService : IStatsService
    {
        private readonly AppDbContext _context;

        public StatsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Stats>> GetAllStatsAsync()
        {
            return await _context.Stats.ToListAsync();
        }

        public async Task<Stats> GetStatsByIdAsync(int characterId)
        {
            return await _context.Stats.FindAsync(characterId);
        }

        public async Task<Stats> CreateStatsAsync(Stats stats)
        {
            _context.Stats.Add(stats);
            await _context.SaveChangesAsync();
            return stats;
        }

        public async Task<Stats> UpdateStatsAsync(int characterId, Stats updatedStats)
        {
            var existingStats = await _context.Stats.FindAsync(characterId);
            if (existingStats == null)
            {
                return null;
            }

            existingStats.Strength = updatedStats.Strength;
            existingStats.Dexterity = updatedStats.Dexterity;
            existingStats.Constitution = updatedStats.Constitution;
            existingStats.Intelligence = updatedStats.Intelligence;
            existingStats.Wisdom = updatedStats.Wisdom;
            existingStats.Charisma = updatedStats.Charisma;
            existingStats.Health = updatedStats.Health;
            existingStats.Initiative = updatedStats.Initiative;
            existingStats.Armor_class = updatedStats.Armor_class;

            await _context.SaveChangesAsync();
            return existingStats;
        }

        public async Task<bool> DeleteStatsAsync(int characterId)
        {
            var stats = await _context.Stats.FindAsync(characterId);
            if (stats == null)
            {
                return false;
            }

            _context.Stats.Remove(stats);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
