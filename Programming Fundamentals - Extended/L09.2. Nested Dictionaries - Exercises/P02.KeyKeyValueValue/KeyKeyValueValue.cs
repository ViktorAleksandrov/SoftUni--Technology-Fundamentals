namespace P02.KeyKeyValueValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyKeyValueValue
    {
        public static void Main()
        {
            var keyToFind = Console.ReadLine();
            var valueToFind = Console.ReadLine();

            var linesNumber = int.Parse(Console.ReadLine());

            var keysValues = new Dictionary<string, List<string>>();

            for (var index = 0; index < linesNumber; index++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { " => " }, StringSplitOptions.None);

                var key = inputLine[0];
                var values = inputLine[1].Split(';').ToList();

                keysValues.Add(key, values);
            }

            foreach (var key in keysValues.Keys)
            {
                if (!key.Contains(keyToFind))
                {
                    continue;
                }

                Console.WriteLine($"{key}:");

                var values = keysValues[key];

                foreach (var value in values)
                {
                    if (value.Contains(valueToFind))
                    {
                        Console.WriteLine($"-{value}");
                    }
                }
            }
        }
    }
}