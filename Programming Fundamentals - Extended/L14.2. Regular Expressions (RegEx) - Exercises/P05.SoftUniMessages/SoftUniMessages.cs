namespace P05.SoftUniMessages
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SoftUniMessages
    {
        public static void Main()
        {
            while (true)
            {
                var message = Console.ReadLine();

                if (message == "Decrypt!")
                {
                    break;
                }

                var messageLength = int.Parse(Console.ReadLine());

                var regex = new Regex($@"^\d+[a-zA-Z]{{{messageLength}}}([^a-zA-Z]+|\d+)$");

                if (!regex.IsMatch(message))
                {
                    continue;
                }

                var letters = message
                    .Where(char.IsLetter)
                    .ToArray();

                var digits = message
                    .Where(char.IsDigit)
                    .Select(ch => ch - '0')
                    .ToArray();

                var result = string.Empty;

                foreach (var digit in digits)
                {
                    if (digit < letters.Length)
                    {
                        result += letters[digit];
                    }
                }

                var encryptedText = new string(letters);

                Console.WriteLine($"{encryptedText} = {result}");
            }
        }
    }
}