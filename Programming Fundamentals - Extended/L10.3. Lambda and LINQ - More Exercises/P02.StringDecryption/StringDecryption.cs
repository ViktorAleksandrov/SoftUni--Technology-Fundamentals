namespace P02.StringDecryption
{
    using System;
    using System.Linq;

    public class StringDecryption
    {
        public static void Main()
        {
            var takeSkipNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var filteredNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= 65 && n <= 90)
                .ToList();

            var skipNumber = takeSkipNumbers[0];
            var takeNumber = takeSkipNumbers[1];

            var resultChars = filteredNumbers
                .Skip(skipNumber)
                .Take(takeNumber)
                .Select(n => (char)n)
                .ToList();

            Console.WriteLine(string.Join(string.Empty, resultChars));
        }
    }
}