using Neocare.Domain.Entities;
using Neocare.Domain.Interfaces;

namespace Neocare.Infrastructure.Repositories
{
    public class InMemoryStressEntryRepository : IStressEntryRepository
    {
        private readonly List<StressEntry> _entries = new();

        public Task<StressEntry?> GetByIdAsync(Guid id)
        {
            var entry = _entries.FirstOrDefault(e => e.Id == id);
            return Task.FromResult(entry);
        }

        public Task<IEnumerable<StressEntry>> GetAllAsync()
        {
            return Task.FromResult(_entries.AsEnumerable());
        }

        public Task<IEnumerable<StressEntry>> GetByUserIdAsync(string userId)
        {
            var entries = _entries.Where(e => e.UserId == userId);
            return Task.FromResult(entries);
        }

        public Task<StressEntry> CreateAsync(StressEntry entry)
        {
            _entries.Add(entry);
            return Task.FromResult(entry);
        }

        public Task UpdateAsync(StressEntry entry)
        {
            var index = _entries.FindIndex(e => e.Id == entry.Id);
            if (index != -1)
            {
                _entries[index] = entry;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var entry = _entries.FirstOrDefault(e => e.Id == id);
            if (entry != null)
            {
                _entries.Remove(entry);
            }
            return Task.CompletedTask;
        }
    }
}