namespace Neocare.Domain.Entities
{
    public class StressEntry
    {
        public Guid Id { get; set; }
        public int StressLevel { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Symptoms { get; set; } = new();
        public DateTime RecordedAt { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}