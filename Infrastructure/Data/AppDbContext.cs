using DnDCharacterCreator.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DnDCharacterCreator.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Spells> Spells { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Race> Races { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characters>()
                .HasOne<Class>()
                .WithMany()
                .HasForeignKey(c => c.Class);

            modelBuilder.Entity<Characters>()
                .HasOne<Background>()
                .WithMany()
                .HasForeignKey(c => c.Background);

            modelBuilder.Entity<Characters>()
                .HasOne<Race>()
                .WithMany()
                .HasForeignKey(c => c.Race);

            modelBuilder.Entity<Characters>()
                .HasOne<Details>()
                .WithMany()
                .HasForeignKey(c => c.Description);

            modelBuilder.Entity<Characters>()
                .HasOne<Skills>()
                .WithMany()
                .HasForeignKey(c => c.Skills);

            modelBuilder.Entity<Characters>()
                .HasOne<Stats>()
                .WithMany()
                .HasForeignKey(c => c.Stats);

            modelBuilder.Entity<Characters>()
                .HasOne<Inventory>()
                .WithMany()
                .HasForeignKey(c => c.Inventory);

            modelBuilder.Entity<Spells>()
                .HasOne<Classes>()
                .WithMany()
                .HasForeignKey(s => s.Classes);
            
        }
    }
}
