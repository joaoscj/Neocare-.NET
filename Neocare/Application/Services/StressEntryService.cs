using Neocare.Application.DTOs;
using Neocare.Domain.Entities;
using Neocare.Domain.Interfaces;

namespace Neocare.Application.Services
{
    public class StressEntryService
    {
        private readonly IStressEntryRepository _repository;

        public StressEntryService(IStressEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task<StressEntryDto> GetByIdAsync(Guid id)
        {
            var entry = await _repository.GetByIdAsync(id);
            if (entry == null)
                throw new KeyNotFoundException("Stress entry not found");

            return MapToDto(entry);
        }

        public async Task<IEnumerable<StressEntryDto>> GetAllAsync()
        {
            var entries = await _repository.GetAllAsync();
            return entries.Select(MapToDto);
        }

        public async Task<IEnumerable<StressEntryDto>> GetByUserIdAsync(string userId)
        {
            var entries = await _repository.GetByUserIdAsync(userId);
            return entries.Select(MapToDto);
        }

        public async Task<StressEntryDto> CreateAsync(CreateStressEntryDto createDto)
        {
            var entry = new StressEntry
            {
                Id = Guid.NewGuid(),
                StressLevel = createDto.StressLevel,
                Description = createDto.Description,
                Symptoms = createDto.Symptoms,
                RecordedAt = DateTime.UtcNow,
                UserId = createDto.UserId
            };

            var created = await _repository.CreateAsync(entry);
            return MapToDto(created);
        }

        public async Task UpdateAsync(Guid id, UpdateStressEntryDto updateDto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                throw new KeyNotFoundException("Stress entry not found");

            existing.StressLevel = updateDto.StressLevel;
            existing.Description = updateDto.Description;
            existing.Symptoms = updateDto.Symptoms;

            await _repository.UpdateAsync(existing);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        private static StressEntryDto MapToDto(StressEntry entry)
        {
            return new StressEntryDto
            {
                Id = entry.Id,
                StressLevel = entry.StressLevel,
                Description = entry.Description,
                Symptoms = entry.Symptoms,
                RecordedAt = entry.RecordedAt,
                UserId = entry.UserId
            };
        }
    }
}