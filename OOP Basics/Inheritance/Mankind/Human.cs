namespace Mankind
{
    using System;

    public class Human
    {
        private string firstname;
        private string lastname;

        public Human(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string FirstName
        {
            get { return this.firstname; }
            private set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                this.firstname = value;
            }
        }

        public string LastName
        {
            get { return this.lastname; }
            private set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.lastname = value;
            }
        }
    }
}
