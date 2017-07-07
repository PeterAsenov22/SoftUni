namespace Mankind
{
    using System;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstname, string lastname, string facultyNumber) : base(firstname, lastname)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set
            {
                var regex = new Regex(@"^[\da-zA-Z]{5,10}$");
                if (regex.IsMatch(value))
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }
    }
}
