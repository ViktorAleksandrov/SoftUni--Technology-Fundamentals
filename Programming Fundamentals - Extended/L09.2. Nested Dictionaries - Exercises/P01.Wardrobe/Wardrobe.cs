namespace P01.Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            var linesNumber = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (var index = 0; index < linesNumber; index++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var color = inputLine[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                var clothes = inputLine[1].Split(',');

                foreach (var clothing in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothing))
                    {
                        wardrobe[color][clothing] = 0;
                    }

                    wardrobe[color][clothing]++;
                }
            }

            var clothesToLookFor = Console.ReadLine().Split();

            var neededColor = clothesToLookFor[0];
            var neededClothing = clothesToLookFor[1];

            foreach (var color in wardrobe.Keys)
            {
                Console.WriteLine($"{color} clothes:");

                var clothes = wardrobe[color];

                foreach (var clothing in clothes.Keys)
                {
                    var count = clothes[clothing];

                    if (color == neededColor && clothing == neededClothing)
                    {
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }
            }
        }
    }
}