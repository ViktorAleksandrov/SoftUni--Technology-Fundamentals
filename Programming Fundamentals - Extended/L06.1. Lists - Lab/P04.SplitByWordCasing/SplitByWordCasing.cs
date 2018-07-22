namespace P04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var inputText = Console.ReadLine()
                .Split(
                new[]
                {
                    ',',
                    ';',
                    ':',
                    '.',
                    '!',
                    '(',
                    ')',
                    '"',
                    '\'',
                    '\\',
                    '/',
                    '[',
                    ']',
                    ' '
                },
                StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var currentWord in inputText)
            {
                if (currentWord.All(char.IsLower))
                {
                    lowerCaseWords.Add(currentWord);
                }
                else if (currentWord.All(char.IsUpper))
                {
                    upperCaseWords.Add(currentWord);
                }
                else
                {
                    mixedCaseWords.Add(currentWord);
                }
            }

            var lowerCase = string.Join(", ", lowerCaseWords);
            var mixedCase = string.Join(", ", mixedCaseWords);
            var upperCase = string.Join(", ", upperCaseWords);

            Console.WriteLine($"Lower-case: {lowerCase}\n" +
                              $"Mixed-case: {mixedCase}\n" +
                              $"Upper-case: {upperCase}");
        }
    }
}