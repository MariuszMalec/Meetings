﻿namespace Meetings.WebMvcApp.Models
{
    public class UserView : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
    }
}
