namespace Students_Grades
{
    using Students_By_Group;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsGrades
    {
        static void Main()
        {
            var students = new List<Student>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputParams = input.Split(' ');
                var grades = new List<int>();
                for (int i = 2; i < inputParams.Length; i++)
                {
                    grades.Add(int.Parse(inputParams[i]));
                }

                var student = new Student()
                {
                    FirstName = inputParams[0],
                    SecondName = inputParams[1],
                    Grades = grades
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            foreach (var student in students.Where(x => x.Grades.Where(m=>m<=3).Count()>=2))
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}");
            }
        }
    }
}
