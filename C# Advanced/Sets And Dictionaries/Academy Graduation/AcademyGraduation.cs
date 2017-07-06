namespace Academy_Graduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AcademyGraduation
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var studentName = Console.ReadLine();
                var grades = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                double average = grades.Sum() / grades.Count();
                students[studentName] = average;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");         
            }
        }
    }
}
