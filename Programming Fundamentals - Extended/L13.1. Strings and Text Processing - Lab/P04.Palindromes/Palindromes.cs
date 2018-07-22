namespace P04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(
                    new[] { ' ', ',', '.', '?', '!' },
                    StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}