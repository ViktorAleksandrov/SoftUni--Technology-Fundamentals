namespace P02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldLength = int.Parse(Console.ReadLine());

            var field = new int[fieldLength];

            var ladybugsIndices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= 0 && n < fieldLength);

            foreach (var index in ladybugsIndices)
            {
                field[index] = 1;
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                var commandTokens = command.Split();

                var ladybugIndex = int.Parse(commandTokens[0]);
                var direction = commandTokens[1];
                var flyLength = int.Parse(commandTokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= fieldLength)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                if (direction == "left")
                {
                    flyLength = -flyLength;
                }

                field[ladybugIndex] = 0;

                while (true)
                {
                    ladybugIndex += flyLength;

                    if (ladybugIndex < 0 || ladybugIndex >= fieldLength)
                    {
                        break;
                    }

                    if (field[ladybugIndex] == 0)
                    {
                        field[ladybugIndex] = 1;

                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}