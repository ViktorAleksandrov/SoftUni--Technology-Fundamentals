namespace P02.WordEncounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine();

            var letter = filter[0];
            var occurence = filter[1] - '0';

            var sentence = Console.ReadLine();

            var regex = new Regex("^[A-Z].*[!?.]$");

            var words = new List<string>();

            while (sentence != "end")
            {
                if (regex.IsMatch(sentence))
                {
                    var matchedWords = Regex.Matches(sentence, @"\w+");

                    foreach (Match word in matchedWords)
                    {
                        var count = word.Value.Count(ch => ch == letter);

                        if (count >= occurence)
                        {
                            words.Add(word.Value);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}