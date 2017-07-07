namespace Mankind
{
    using System;

    public class Mankind
    {
        public static void Main()
        {
            var studentInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]),
                    double.Parse(workerInfo[3]));

                Console.WriteLine($"First Name: {student.FirstName}");
                Console.WriteLine($"Last Name: {student.LastName}");
                Console.WriteLine($"Faculty number: {student.FacultyNumber}");
                Console.WriteLine();
                Console.WriteLine($"First Name: {worker.FirstName}");
                Console.WriteLine($"Last Name: {worker.LastName}");
                Console.WriteLine($"Week Salary: {worker.Salary:F2}");
                Console.WriteLine($"Hours per day: {worker.HoursWorked:F2}");
                Console.WriteLine($"Salary per hour: {worker.SalaryPerHour():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }        
        }
    }
}
