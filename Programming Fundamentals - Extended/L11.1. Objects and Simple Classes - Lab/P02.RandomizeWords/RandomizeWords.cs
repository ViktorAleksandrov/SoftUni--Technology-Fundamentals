namespace P02.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();

            var rnd = new Random();

            while (words.Count > 0)
            {
                var randomIndex = rnd.Next(words.Count);

                var currentWord = words[randomIndex];

                Console.WriteLine(currentWord);

                words.RemoveAt(randomIndex);
            }
        }
    }
}