namespace P02.ArrayManipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                var index = 0;
                var remainder = 0;

                switch (command[0])
                {
                    case "exchange":
                        index = int.Parse(command[1]);

                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");

                            break;
                        }

                        var lefPart = numbers
                            .Take(index + 1)
                            .ToList();

                        numbers = numbers
                            .Skip(index + 1)
                            .Concat(lefPart)
                            .ToList();

                        break;

                    case "max":
                    case "min":
                        remainder = command[1] == "even" ? 0 : 1;

                        var filteredElements = numbers
                            .Where(n => n % 2 == remainder)
                            .ToList();

                        if (filteredElements.Any())
                        {
                            var searchedElement = command[0] == "max"
                                ? filteredElements.Max()
                                : filteredElements.Min();

                            index = numbers.LastIndexOf(searchedElement);

                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;

                    case "first":
                    case "last":
                        var count = int.Parse(command[1]);

                        if (count > numbers.Count)
                        {
                            Console.WriteLine("Invalid count");

                            break;
                        }

                        remainder = command[2] == "even" ? 0 : 1;

                        var result = numbers.Where(n => n % 2 == remainder);

                        result = command[0] == "first"
                            ? result.Take(count)
                            : result.Reverse().Take(count).Reverse();

                        Console.WriteLine($"[{string.Join(", ", result)}]");

                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}