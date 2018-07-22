namespace P02.CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();

            var word = Console.ReadLine().ToLower();

            var index = text.IndexOf(word);

            var counter = 0;

            while (index != -1)
            {
                index = text.IndexOf(word, index + 1);

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}