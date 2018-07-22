namespace P3.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt")
                .ToLower()
                .Split();

            var wordsInTxt = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new[] { '-', '.', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsOccurences = new Dictionary<string, int>();

            foreach (var word in wordsInTxt)
            {
                if (!wordsOccurences.ContainsKey(word) && words.Contains(word))
                {
                    wordsOccurences[word] = 1;
                }
                else if (words.Contains(word))
                {
                    wordsOccurences[word]++;
                }
            }

            var result = wordsOccurences
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} -> {kvp.Value}");

            File.WriteAllLines("result.txt", result);
        }
    }
}