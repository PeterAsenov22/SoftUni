﻿namespace Football_Team_Generator
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
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        private int Endurance
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100. ");
                }
                this.endurance = value;
            }
        }

        private int Sprint
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100. ");
                }
                this.sprint = value;
            }
        }

        private int Shooting
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100. ");
                }
                this.shooting = value;
            }
        }

        private int Dribble
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100. ");
                }
                this.dribble = value;
            }
        }

        private int Passing
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100. ");
                }
                this.passing = value;
            }
        }

        public double Overall()
        {
            double overall = (this.dribble + this.endurance + this.passing + this.sprint + this.shooting) / 5.0;
            return overall;
        }
    }
}
