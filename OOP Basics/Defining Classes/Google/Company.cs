using System;
using System.Runtime.InteropServices;

namespace Google
{
    public class Company
    {
        private string name;
        private string department;
        private double? salary ;

        public double? Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Company()
        {   
        }

        public Company(string name, string department, double? salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public  string Department
        {
            get { return this.department; }

        }

        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            if (this.name != null)
            {
                return $"{this.name} {this.department} {this.salary:F2}";
            }
            else
            {
                return $"";
            }
        }
    }
}
