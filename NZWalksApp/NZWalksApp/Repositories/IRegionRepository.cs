using NZWalksApp.Models.Domain;

namespace NZWalksApp.Repositories
{
    public interface IRegionRepository
    {
        Task <IEnumerable<Region>> GetAllAsync();
    }
}
