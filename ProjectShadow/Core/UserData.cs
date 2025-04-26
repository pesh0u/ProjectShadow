using System;

namespace ProjectShadow.Core
{
    class UserData
    {
        // Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserStatus { get; set; } // 5 - Owner, 4 - Admin, 3 - Moderator, 2 - User, 1 - Guest
        public int UserActive { get; set; } // 1 - Active, 0 - Inactive
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Callsign { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CardNumber { get; set; }
        public string UserFile { get; set; }
    }
}
