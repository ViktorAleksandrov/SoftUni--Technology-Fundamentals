namespace P07.CapitalizeWords
{
    using System;
    using System.Text;

    public class CapitalizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var sentence = input
                    .ToLower()
                    .Split(
                        new[] { ' ', ',', '.', '?', '!', ':', ';', '-' },
                        StringSplitOptions.RemoveEmptyEntries);

                for (var index = 0; index < sentence.Length; index++)
                {
                    var currentWord = new StringBuilder(sentence[index]);

                    currentWord[0] = char.ToUpper(currentWord[0]);

                    sentence[index] = currentWord.ToString();
                }

                Console.WriteLine(string.Join(", ", sentence));

                input = Console.ReadLine();
            }
        }
    }
}