namespace P01.RabbitHole
{
    using System;
    using System.Linq;

    public class RabbitHole
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var energy = int.Parse(Console.ReadLine());

            var index = 0;

            while (true)
            {
                var currentElement = input[index];

                if (currentElement == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");

                    break;
                }

                var elementParts = currentElement.Split('|');

                var listLength = input.Count;

                var jump = int.Parse(elementParts[1]);

                switch (elementParts[0])
                {
                    case "Left":
                        index = Math.Abs((index - jump) % listLength);
                        energy -= jump;
                        break;
                    case "Right":
                        index = (jump + index) % listLength;
                        energy -= jump;
                        break;
                }

                if (energy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");

                    break;
                }

                if (elementParts[0] == "Bomb")
                {
                    energy -= jump;
                    input.RemoveAt(index);
                    index = 0;

                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");

                        break;
                    }
                }

                if (input[input.Count - 1] != "RabbitHole")
                {
                    input.RemoveAt(input.Count - 1);
                }

                input.Add($"Bomb|{energy}");
            }
        }
    }
}