namespace WorkForce
{
    using System;
    using Employees;

    public delegate void JobDoneEventHander(object sender, JobEventArgs e);

    public class Job
    {
        private IEmploee employee;
        private int hoursRequired;

        public event JobDoneEventHander JobDone;

        public Job(string name, int hoursRequired, IEmploee employee)
        {
            this.employee = employee;
            this.Name = name;
            this.HoursRequired = hoursRequired;
            this.IsDone = false;
        }

        public string Name { get; private set; }

        public bool IsDone { get; private set; }

        public int HoursRequired
        {
            get { return this.hoursRequired; }
            private set
            {
                if (value <= 0)
                {
                    if (JobDone != null)
                    {
                        JobDone(this,new JobEventArgs(this));
                    }
                }

                this.hoursRequired = value;
            }
        }

        public void Update()
        {
            if (!IsDone)
            {
                this.HoursRequired -= employee.WorkingHoursPerWeek;
            }
        }

        public void OnJobDone(object sender, JobEventArgs e)
        {
            Console.WriteLine($"Job {this.Name} done!");
            this.IsDone = true;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.HoursRequired}";
        }
    }
}
