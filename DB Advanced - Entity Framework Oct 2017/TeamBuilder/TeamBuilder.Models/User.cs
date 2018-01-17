namespace TeamBuilder.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TeamBuilder.Models.Enums;
    using TeamBuilder.Models.Validation;

    public class User
    {
        public User()
        {
            this.CreatedEvents = new List<Event>();
            this.ReceivedInvitations = new List<Invitation>();
            this.OwnedTeams = new List<Team>();
            this.UserTeams = new List<UserTeam>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Password(6, 30, ContainsDigit = true, ContainsUppercase = true)]
        public string Password { get; set; }

        public Gender Gender { get; set; }

        [Range(0, int.MaxValue)]
        public int? Age { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Event> CreatedEvents { get; set; }

        public ICollection<Invitation> ReceivedInvitations { get; set; }

        public ICollection<Team> OwnedTeams { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }
    }
}
