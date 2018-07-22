namespace P03.TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.None);

            var text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                var replacement = new string('*', banWord.Length);

                text = text.Replace(banWord, replacement);
            }

            Console.WriteLine(text);
        }
    }
}