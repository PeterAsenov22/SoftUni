namespace Mankind
{
    using System;

    public class Worker : Human
    {
        private decimal salary;
        private double hoursWorked;

        private const int MinHoursWorked = 1;
        private const int MaxHoursWorked = 12;
        private const int WorkingDays = 5;

        public Worker(string firstname, string lastname, decimal salary, double hoursWorked) : base(firstname, lastname)
        {
            if (lastname.Length < 4)
            {
                throw new ArgumentException("Expected length more than 3 symbols! Argument: lastName");
            }

            this.Salary = salary;
            this.HoursWorked = hoursWorked;
        }
        public decimal Salary
        {
            get { return this.salary; }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.salary = value;
            }
        }

        public double HoursWorked
        {
            get { return this.hoursWorked; }
            private set
            {
                if (value < MinHoursWorked || value > MaxHoursWorked)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.hoursWorked = value;
            }
        }

        public decimal SalaryPerHour()
        {
            return (decimal)((this.salary / WorkingDays) / (decimal)this.hoursWorked);
        }
    }
}
