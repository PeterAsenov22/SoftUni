using Students_By_Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Enrolled_in_2014_and_2015
{
    public class EnrolledStudents
    {
        public static void Main()
        {
            var students = new List<Student>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputParams = input.Split(' ');
                var grades = new List<int>();
                for (int i = 1; i < inputParams.Length; i++)
                {
                    grades.Add(int.Parse(inputParams[i]));
                }

                var student = new Student()
                {
                    FacultyNumber = inputParams[0],
                    Grades = grades
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            foreach (var student in students.Where(x => x.Grades.Where(m => m <= 3).Count() >= 2))
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}");
            }
        }
    }
}
