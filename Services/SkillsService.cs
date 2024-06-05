using DnDCharacterCreator.Infrastructure.Data;
using DnDCharacterCreator.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DnDCharacterCreator.Services
{
    public class SkillsService
    {
        private readonly AppDbContext _context;
        public SkillsService(AppDbContext context)
        {
            _context = context;
        }
       
    }
}


