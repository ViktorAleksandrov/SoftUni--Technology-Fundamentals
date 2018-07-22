namespace P06.FilterBase
{
    using System;
    using System.Collections.Generic;

    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var namesAges = new Dictionary<string, int>();
            var namesSalaries = new Dictionary<string, double>();
            var namesPositions = new Dictionary<string, string>();

            while (input != "filter base")
            {
                var employeeInfo = input.Split();

                var name = employeeInfo[0];

                if (int.TryParse(employeeInfo[2], out var age))
                {
                    namesAges[name] = age;
                }
                else if (double.TryParse(employeeInfo[2], out var salary))
                {
                    namesSalaries[name] = salary;
                }
                else
                {
                    var position = employeeInfo[2];

                    namesPositions[name] = position;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            switch (input)
            {
                case "Age":
                    foreach (var name in namesAges.Keys)
                    {
                        var age = namesAges[name];

                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Age: {age}");
                        Console.WriteLine(new string('=', 20));
                    }

                    break;

                case "Salary":
                    foreach (var name in namesSalaries.Keys)
                    {
                        var salary = namesSalaries[name];

                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Salary: {salary:f2}");
                        Console.WriteLine(new string('=', 20));
                    }

                    break;

                case "Position":
                    foreach (var name in namesPositions.Keys)
                    {
                        var position = namesPositions[name];

                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Position: {position}");
                        Console.WriteLine(new string('=', 20));
                    }

                    break;
            }
        }
    }
}