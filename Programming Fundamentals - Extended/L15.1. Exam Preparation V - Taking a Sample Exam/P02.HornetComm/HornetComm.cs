namespace P02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var messageRegex = new Regex(@"^(?<code>\d+) <-> (?<message>[a-zA-Z\d]+)$");
            var broadcastRegex = new Regex(@"^(?<message>\D+) <-> (?<frequency>[a-zA-Z\d]+)$");

            var messages = new List<string>();
            var broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                if (messageRegex.IsMatch(input))
                {
                    var matchedMessage = messageRegex.Match(input);

                    var codeArr = matchedMessage.Groups["code"].Value.ToCharArray();

                    var code = new string(codeArr.Reverse().ToArray());
                    var message = matchedMessage.Groups["message"].Value;

                    messages.Add($"{code} -> {message}");
                }
                else if (broadcastRegex.IsMatch(input))
                {
                    var matchedBroadcast = broadcastRegex.Match(input);

                    var frequencyArr = matchedBroadcast.Groups["frequency"].Value.ToCharArray();

                    for (var index = 0; index < frequencyArr.Length; index++)
                    {
                        if (char.IsLower(frequencyArr[index]))
                        {
                            frequencyArr[index] = char.ToUpper(frequencyArr[index]);
                        }
                        else if (char.IsUpper(frequencyArr[index]))
                        {
                            frequencyArr[index] = char.ToLower(frequencyArr[index]);
                        }
                    }

                    var frequency = new string(frequencyArr);
                    var message = matchedBroadcast.Groups["message"].Value;

                    broadcasts.Add($"{frequency} -> {message}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any()
                ? string.Join(Environment.NewLine, broadcasts)
                : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages)
                : "None");
        }
    }
}