namespace _06.Football_Team_Generator
{
    using System;

    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }

            private set
            {
                this.ValidateStats(nameof(this.Endurance), value);
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }

            private set
            {
                this.ValidateStats(nameof(this.Sprint), value);
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }

            private set
            {
                this.ValidateStats(nameof(this.Dribble), value);
                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }

            private set
            {
                this.ValidateStats(nameof(this.Passing), value);
                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }

            private set
            {
                this.ValidateStats(nameof(this.Shooting), value);
                this.shooting = value;
            }
        }

        public double SkillLevel()
        {
            return (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        }

        private void ValidateStats(string stat, int power)
        {
            if (power < 0 || power > 100)
            {
                throw new ArgumentException($"{stat} should be between 0 and 100.");
            }
        }
    }
}