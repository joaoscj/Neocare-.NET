using Neocare.Domain.Entities;

namespace Neocare.Domain.Interfaces
{
    public interface IStressEntryRepository
    {
        Task<StressEntry?> GetByIdAsync(Guid id);
        Task<IEnumerable<StressEntry>> GetAllAsync();
        Task<IEnumerable<StressEntry>> GetByUserIdAsync(string userId);
        Task<StressEntry> CreateAsync(StressEntry entry);
        Task UpdateAsync(StressEntry entry);
        Task DeleteAsync(Guid id);
    }
}