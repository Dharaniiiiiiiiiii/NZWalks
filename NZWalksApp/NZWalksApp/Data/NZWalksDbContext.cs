using Microsoft.EntityFrameworkCore;
using NZWalksApp.Models.Domain;

namespace NZWalksApp.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions <NZWalksDbContext>options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        public DbSet<WalkDifficulty> walksDifficulty { get; set; }
       
    }
}
