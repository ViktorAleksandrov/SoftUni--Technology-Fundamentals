namespace P04.CubicMessages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            while (true)
            {
                var encryptedMessage = Console.ReadLine();

                if (encryptedMessage == "Over!")
                {
                    break;
                }

                var validMesageLength = int.Parse(Console.ReadLine());

                var messageRegex = new Regex(
                    $@"^\d+(?<message>[a-zA-Z]{{{validMesageLength}}})[^a-zA-Z]*$");

                var matchedMessage = messageRegex.Match(encryptedMessage);

                var message = matchedMessage.Groups["message"].Value;

                if (!matchedMessage.Success)
                {
                    continue;
                }

                var digits = matchedMessage.Groups[0].Value
                    .Where(char.IsDigit)
                    .Select(ch => int.Parse(ch.ToString()))
                    .ToArray();

                var verificationCode = new StringBuilder();

                foreach (var digit in digits)
                {
                    if (digit < validMesageLength)
                    {
                        verificationCode.Append(message[digit]);
                    }
                    else
                    {
                        verificationCode.Append(" ");
                    }
                }

                Console.WriteLine($"{message} == {verificationCode}");
            }
        }
    }
}