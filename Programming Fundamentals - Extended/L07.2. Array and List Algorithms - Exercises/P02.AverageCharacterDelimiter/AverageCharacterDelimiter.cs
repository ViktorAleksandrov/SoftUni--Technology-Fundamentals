namespace P02.AverageCharacterDelimiter
{
    using System;
    using System.Linq;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var sum = 0;
            var charsCount = 0;

            foreach (var element in input)
            {
                foreach (var character in element)
                {
                    sum += character;
                }

                charsCount += element.Length;
            }

            var averageChar = (char)(sum / charsCount);

            var delimiter = averageChar.ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter, input));
        }
    }
}