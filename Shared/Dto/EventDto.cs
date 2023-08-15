namespace Shared.Models
{
    public class EventDto
    {
        public Guid EventId { get; set; }
        public string EventLocation { get; set; }
        public string Description { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
    }
}
