using Microsoft.EntityFrameworkCore;
using Festival.DAL.Models;

namespace Festival.DAL.Data
{
    public class FestivalDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }
}