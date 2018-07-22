namespace P01.LetterRepetition
{
    using System;
    using System.Collections.Generic;

    public class LetterRepetition
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var charsCounts = new Dictionary<char, int>();

            foreach (var element in inputString)
            {
                if (!charsCounts.ContainsKey(element))
                {
                    charsCounts[element] = 0;
                }

                charsCounts[element]++;
            }

            foreach (var character in charsCounts.Keys)
            {
                var count = charsCounts[character];

                Console.WriteLine($"{character} -> {count}");
            }
        }
    }
}