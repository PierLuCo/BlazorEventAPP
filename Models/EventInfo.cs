namespace EventEase.Models
{
    public class EventInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Attendee> Attendees { get; set; } = new List<Attendee>();

        public static List<EventInfo> GetMockEvents() => new()
        {
            new EventInfo
            {
                Id = 1,
                Name = "Community Concert",
                Date = DateTime.Today.AddDays(14),
                Location = "Riverfront Park",
                Description = "Live music under the stars."
            },
            new EventInfo
            {
                Id = 2,
                Name = "Tech Meetup",
                Date = DateTime.Today.AddDays(21),
                Location = "Downtown Conference Center",
                Description = "Networking and product demos."
            },
            new EventInfo
            {
                Id = 3,
                Name = "Art & Food Festival",
                Date = DateTime.Today.AddDays(30),
                Location = "Main Street Plaza",
                Description = "Local artists and cuisine."
            }
        };
    }
}
