namespace P03.BoomingCannon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class BoomingCannon
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split();

            var text = Console.ReadLine();

            var regex = new Regex(@"\\<<<.*");

            var cannonShots = regex.Matches(text);

            var shotDistance = int.Parse(elements[0]);
            var destroyedElements = int.Parse(elements[1]);

            var words = new List<string>();

            foreach (var cannonShot in cannonShots)
            {
                var shot = cannonShot.ToString()
                    .Split(
                        new[] { "\\<<<" },
                        StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in shot)
                {
                    var wordArr = word
                        .Skip(shotDistance)
                        .Take(destroyedElements)
                        .ToArray();

                    words.Add(new string(wordArr));
                }
            }

            Console.WriteLine(string.Join("/\\", words.Where(w => w != string.Empty)));
        }
    }
}