namespace WorkForce
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Employees;

    public class StartUp
    {
        public static void Main()
        {
            JobList jobs = new JobList();
            List<IEmploee> employees = new List<IEmploee>();

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] cmdArgs = input.Split();
                switch (cmdArgs[0])
                {
                    case "Job":
                        Job newJob = new Job(cmdArgs[1],int.Parse(cmdArgs[2]),employees.FirstOrDefault(x=>x.Name == cmdArgs[3]));
                        newJob.JobDone += newJob.OnJobDone;
                        jobs.Add(newJob);
                        break;
                    case "StandartEmployee":
                        employees.Add(new StandartEmployee(cmdArgs[1]));
                        break;
                    case "PartTimeEmployee":
                        employees.Add(new PartTimeEmployee(cmdArgs[1]));
                        break;
                    case "Pass":
                        PassWeek(jobs);
                        break;
                    case "Status":
                        Status(jobs);
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void Status(List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                if (!job.IsDone)
                {
                    Console.WriteLine(job);
                }            
            }
        }

        private static void PassWeek(List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                job.Update();
            }
        }
    }
}
