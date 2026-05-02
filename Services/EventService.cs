using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private static List<EventInfo> _events = EventInfo.GetMockEvents();

        public List<EventInfo> GetAllEvents()
        {
            return _events;
        }

        public EventInfo? GetEventById(int id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }

        public void AddAttendee(int eventId, Attendee attendee)
        {
            var eventItem = GetEventById(eventId);
            if (eventItem != null && !eventItem.Attendees.Any(a => a.Email == attendee.Email))
            {
                eventItem.Attendees.Add(attendee);
            }
        }
    }
}
