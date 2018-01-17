namespace TeamBuilder.Models
{
    using System;
    using System.Collections.Generic;
    using TeamBuilder.Models.Validation;

    public class Event
    {
        public Event()
        {
            this.Teams = new List<EventTeam>();
        }

        private DateTime endDate;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate
        {
            get
            {
                return this.endDate;
            }

            set
            {
                if (value < this.StartDate.Value)
                {
                    throw new ArgumentException("End date must be after start date");
                }

                this.endDate = value.Value;
            }
        }

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        public ICollection<EventTeam> Teams { get; set; }
    }
}
