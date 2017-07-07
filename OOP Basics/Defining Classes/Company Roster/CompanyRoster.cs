namespace Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CompanyRoster
    {
        public static void Main()
        {
            var departments = new Dictionary<string,List<decimal>>();
            var employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var employee = new Employee(inputParams[0],decimal.Parse(inputParams[1]),inputParams[2],inputParams[3]);
                if (inputParams.Length == 6)
                {
                    employee.Email = inputParams[4];
                    employee.Age = int.Parse(inputParams[5]);
                }
                else if (inputParams.Length == 5)
                {
                    int age;
                    var isParsed = int.TryParse(inputParams[4], out age);
                    if (isParsed)
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = inputParams[4];
                    }
                }

                if (!departments.ContainsKey(employee.Department))
                {
                    departments[employee.Department] = new List<decimal>();
                }

                departments[employee.Department].Add(employee.Salary);
                employees.Add(employee);
            }

            var highestAverageSalaryDepartment = departments.OrderByDescending(x => x.Value.Average()).FirstOrDefault();
            var highestPaid = employees.Where(x => x.Department == highestAverageSalaryDepartment.Key).ToList();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");

            foreach (var employee in highestPaid.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
