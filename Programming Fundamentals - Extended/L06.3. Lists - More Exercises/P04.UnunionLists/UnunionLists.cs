namespace P04.UnunionLists
{
    using System;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primalSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var linesCount = int.Parse(Console.ReadLine());

            for (var index = 0; index < linesCount; index++)
            {
                var currentSequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                foreach (var number in currentSequence)
                {
                    if (!primalSequence.Contains(number))
                    {
                        primalSequence.Add(number);
                    }
                    else
                    {
                        while (primalSequence.Contains(number))
                        {
                            primalSequence.Remove(number);
                        }
                    }
                }
            }

            primalSequence.Sort();

            Console.WriteLine(string.Join(" ", primalSequence));
        }
    }
}