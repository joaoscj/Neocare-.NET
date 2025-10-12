namespace Neocare.Application.DTOs
{
    public class StressEntryDto
    {
        public Guid Id { get; set; }
        public int StressLevel { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Symptoms { get; set; } = new();
        public DateTime RecordedAt { get; set; }
        public string UserId { get; set; } = string.Empty;
    }

    public class CreateStressEntryDto
    {
        public int StressLevel { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Symptoms { get; set; } = new();
        public string UserId { get; set; } = string.Empty;
    }

    public class UpdateStressEntryDto
    {
        public int StressLevel { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Symptoms { get; set; } = new();
    }
}