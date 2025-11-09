using Neocare.Domain.Entities;
using Neocare.Domain.Interfaces;

namespace Neocare.Infrastructure.Repositories
{
    public class InMemoryStressEntryRepository : IStressEntryRepository
    {
  private readonly List<StressEntry> _entries = new();

        public Task<StressEntry> GetByIdAsync(Guid id)
        {
        return Task.FromResult(_entries.FirstOrDefault(e => e.Id == id));
        }

        public Task<IEnumerable<StressEntry>> GetAllAsync()
  {
        return Task.FromResult(_entries.AsEnumerable());
        }

        public Task<IEnumerable<StressEntry>> GetByUserIdAsync(string userId)
 {
   return Task.FromResult(_entries.Where(e => e.UserId == userId));
   }

        public Task<StressEntry> CreateAsync(StressEntry entry)
  {
        _entries.Add(entry);
            return Task.FromResult(entry);
        }

        public Task<StressEntry> UpdateAsync(StressEntry entry)
        {
      var index = _entries.FindIndex(e => e.Id == entry.Id);
            if (index == -1)
      return Task.FromResult<StressEntry>(null);

            _entries[index] = entry;
            return Task.FromResult(entry);
   }

        public Task DeleteAsync(Guid id)
        {
            _entries.RemoveAll(e => e.Id == id);
            return Task.CompletedTask;
     }
    }
}