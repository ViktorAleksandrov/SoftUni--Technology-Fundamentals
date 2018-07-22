namespace P04.Phone
{
    using System;
    using System.Linq;

    public class Phone
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var names = Console.ReadLine().Split();

            var commands = Console.ReadLine().Split();

            while (commands[0] != "done")
            {
                var index = 0;

                var currentName = string.Empty;
                var currentPhoneNumber = string.Empty;

                if (phoneNumbers.Contains(commands[1]))
                {
                    index = Array.IndexOf(phoneNumbers, commands[1]);
                    currentName = names[index];
                    currentPhoneNumber = phoneNumbers[index];

                    switch (commands[0])
                    {
                        case "call":
                            Console.WriteLine(
                                $"calling {currentName}...");
                            break;
                        case "message":
                            Console.WriteLine(
                                $"sending sms to {currentName}...");
                            break;
                    }
                }
                else if (names.Contains(commands[1]))
                {
                    index = Array.IndexOf(names, commands[1]);
                    currentPhoneNumber = phoneNumbers[index];

                    switch (commands[0])
                    {
                        case "call":
                            Console.WriteLine(
                                $"calling {currentPhoneNumber}...");
                            break;
                        case "message":
                            Console.WriteLine(
                                $"sending sms to {currentPhoneNumber}...");
                            break;
                    }
                }

                var sum = 0;

                foreach (var element in currentPhoneNumber)
                {
                    if (char.IsDigit(element))
                    {
                        sum += element - '0';
                    }
                }

                switch (commands[0])
                {
                    case "call":

                        var time = TimeSpan.FromSeconds(sum);

                        Console.WriteLine(
                            sum % 2 != 0
                            ? "no answer"
                            : $"call ended. duration: {time.Minutes:d2}:{time.Seconds:d2}");

                        break;

                    case "message":

                        Console.WriteLine(
                            sum % 2 != 0
                            ? "busy"
                            : "meet me there");

                        break;
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}