namespace P01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (input != "go go go")
            {
                var inputParams = input
                    .Split(new[] { " -> ", ", " }, StringSplitOptions.None);

                var topic = inputParams[0];
                var course = inputParams[1];
                var judgeLink = inputParams[2];
                var problems = inputParams.Skip(3).ToList();

                exercises.Add(new Exercise(topic, course, judgeLink, problems));

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");

                Console.Write("Problems for exercises and homework for the ");

                Console.WriteLine($"\"{exercise.CourseName}\" course @ SoftUni.");

                Console.WriteLine(
                    $"Check your solutions here: {exercise.JudgeContestLink}");

                var problemsCount = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{problemsCount}. {problem}");

                    problemsCount++;
                }
            }
        }

        public class Exercise
        {
            public Exercise(
                string topic, string course, string judgeLink, List<string> problems)
            {
                this.Topic = topic;
                this.CourseName = course;
                this.JudgeContestLink = judgeLink;
                this.Problems = problems;
            }

            public string Topic { get; set; }

            public string CourseName { get; set; }

            public string JudgeContestLink { get; set; }

            public List<string> Problems { get; set; }
        }
    }
}