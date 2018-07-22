namespace P19.DebuggingExerciseTrickyStrings
{
    using System;

    public class DebuggingExerciseTrickyStrings
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var currentString = string.Empty;
            var result = string.Empty;

            for (var i = 0; i < numberOfStrings - 1; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }

            currentString = Console.ReadLine();
            result += currentString;

            Console.WriteLine(result);
        }
    }
}