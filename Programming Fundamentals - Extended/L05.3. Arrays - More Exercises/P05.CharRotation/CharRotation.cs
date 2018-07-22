namespace P05.CharRotation
{
    using System;
    using System.Linq;

    public class CharRotation
    {
        public static void Main()
        {
            var chars = Console.ReadLine().ToCharArray();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (var index = 0; index < chars.Length; index++)
            {
                var currentNumber = numbers[index];
                var currentChar = chars[index];

                if (currentNumber % 2 == 0)
                {
                    chars[index] = (char)(currentChar - currentNumber);
                }
                else
                {
                    chars[index] = (char)(currentChar + currentNumber);
                }
            }

            Console.WriteLine(string.Join(string.Empty, chars));
        }
    }
}