namespace P02.CommandInterpreter
{
    using System;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandTokens = command.Split();

                var commandName = commandTokens[0];

                var startIndex = 0;
                var count = 0;

                switch (commandName)
                {
                    case "reverse":
                        startIndex = int.Parse(commandTokens[2]);
                        count = int.Parse(commandTokens[4]);

                        if (startIndex >= 0 && startIndex < input.Count
                            && count >= 0 && count + startIndex <= input.Count)
                        {
                            input.Reverse(startIndex, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "sort":
                        startIndex = int.Parse(commandTokens[2]);
                        count = int.Parse(commandTokens[4]);

                        if (startIndex >= 0 && startIndex < input.Count
                            && count >= 0 && count + startIndex <= input.Count)
                        {
                            input.Sort(startIndex, count, StringComparer.InvariantCulture);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollLeft":
                        count = int.Parse(commandTokens[1]) % input.Count;

                        if (count >= 0)
                        {
                            for (var index = 0; index < count; index++)
                            {
                                var firstElement = input[0];

                                input.RemoveAt(0);

                                input.Add(firstElement);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollRight":
                        count = int.Parse(commandTokens[1]) % input.Count;

                        if (count >= 0)
                        {
                            for (var index = 0; index < count; index++)
                            {
                                var lastElement = input[input.Count - 1];

                                input.RemoveAt(input.Count - 1);

                                input.Insert(0, lastElement);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}