using System.Collections.Generic;
using System.Linq;
using EventEase.Models;

namespace EventEase.Services
{
    public static class RegistrationService
    {
        private static List<Registration> _registrations = new();

        public static void AddRegistration(Registration reg)
        {
            _registrations.Add(reg);
        }

        public static int GetAttendanceCount(int eventId)
        {
            return _registrations.Count(r => r.EventId == eventId);
        }
    }
}