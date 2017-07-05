namespace Filter_Students_By_Email_Domain
{
    using Students_By_Group;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByEmail
    {
        public static void Main()
        {
            var students = new List<Student>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputParams = input.Split(' ');
                var student = new Student()
                {
                    FirstName = inputParams[0],
                    SecondName = inputParams[1],
                    Email = inputParams[2]
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            foreach (var student in students.Where(x => x.Email.Contains("@gmail.com")))
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}");
            }
        }
    }
}
