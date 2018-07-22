namespace P01.Last3ConsecutiveEqualStrings
{
    using System;

    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            var equalElementCounter = 1;

            for (var index = words.Length - 1; index > 0; index--)
            {
                var currentElement = words[index];
                var nextElement = words[index - 1];

                if (currentElement == nextElement)
                {
                    equalElementCounter++;

                    if (equalElementCounter == 3)
                    {
                        var result = words[index];

                        Console.WriteLine($"{result} {result} {result}");

                        return;
                    }
                }
                else
                {
                    equalElementCounter = 1;
                }
            }
        }
    }
}