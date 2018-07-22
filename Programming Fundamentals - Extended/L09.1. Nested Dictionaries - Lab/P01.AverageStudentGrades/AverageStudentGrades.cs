namespace P01.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            var studentsGrades = new Dictionary<string, List<double>>();

            for (var index = 0; index < linesCount; index++)
            {
                var currentRecord = Console.ReadLine().Split();

                var student = currentRecord[0];

                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades[student] = new List<double>();
                }

                var grade = double.Parse(currentRecord[1]);

                studentsGrades[student].Add(grade);
            }

            foreach (var student in studentsGrades.Keys)
            {
                Console.Write($"{student} -> ");

                var grades = studentsGrades[student];

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                var average = grades.Average();

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}