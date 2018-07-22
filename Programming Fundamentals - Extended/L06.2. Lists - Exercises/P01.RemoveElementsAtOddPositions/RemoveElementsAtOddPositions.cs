namespace P01.RemoveElementsAtOddPositions
{
    using System;
    using System.Collections.Generic;

    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            var extractedWords = new List<string>();

            for (var index = 1; index < words.Length; index += 2)
            {
                var currentWord = words[index];

                extractedWords.Add(currentWord);
            }

            var concatWords = string.Join(string.Empty, extractedWords);

            Console.WriteLine(concatWords);
        }
    }
}