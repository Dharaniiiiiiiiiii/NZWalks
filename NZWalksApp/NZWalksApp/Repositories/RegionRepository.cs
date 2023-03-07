using Microsoft.EntityFrameworkCore;
using NZWalksApp.Data;
using NZWalksApp.Models.Domain;
using System.Security.Cryptography.X509Certificates;

namespace NZWalksApp.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
           return  await nZWalksDbContext.Regions.ToListAsync();
            

        }
    }
}
