namespace P03.StringRepeater
{
    using System;

    public class StringRepeater
    {
        private static void Main()
        {
            var inputString = Console.ReadLine();
            var repeatCount = int.Parse(Console.ReadLine());

            var repeatedString = RepeatString(inputString, repeatCount);

            Console.WriteLine(repeatedString);
        }

        private static string RepeatString(string inputString, int repeatCount)
        {
            var repeatedString = string.Empty;

            for (var index = 0; index < repeatCount; index++)
            {
                repeatedString += inputString;
            }

            return repeatedString;
        }
    }
}