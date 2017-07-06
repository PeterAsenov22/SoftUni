namespace Students_Results
{
    using System;

    public class StudentsResults
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average");
            for (int i = 0; i < numberOfStudents; i++)
            {
                var studentDetails = Console.ReadLine().Split(new []{' ', ',', '-'},StringSplitOptions.RemoveEmptyEntries);
                var studentName = studentDetails[0];
                var CAdv = double.Parse(studentDetails[1]);
                var COOP = double.Parse(studentDetails[2]);
                var AdvOOP = double.Parse(studentDetails[3]);
                double averageGrade = (CAdv + AdvOOP + COOP) / 3;

                Console.WriteLine("{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F4}|", studentName, CAdv, COOP, AdvOOP, averageGrade);
            }
        }
    }
}
