using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select an event.")]
        public int EventId { get; set; } = 1;

        [Required(ErrorMessage = "Attendee name is required.")]
        public string AttendeeName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;
    }
}