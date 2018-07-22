namespace P05.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split();

            var data = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine[0] != "end")
            {
                if (inputLine[0] == "flatten")
                {
                    var keyToFlatten = inputLine[1];

                    data[keyToFlatten] = data[keyToFlatten]
                        .ToDictionary(kvp => kvp.Key + kvp.Value, kvp => string.Empty);
                }
                else
                {
                    var key = inputLine[0];
                    var innerKey = inputLine[1];
                    var innerValue = inputLine[2];

                    if (!data.ContainsKey(key))
                    {
                        data[key] = new Dictionary<string, string>();
                    }

                    data[key][innerKey] = innerValue;
                }

                inputLine = Console.ReadLine().Split();
            }

            foreach (var pair in data.OrderByDescending(kvp => kvp.Key.Length))
            {
                var key = pair.Key;

                Console.WriteLine(key);

                var innerValues = pair.Value;

                var keysCount = 1;

                foreach (var kvp in innerValues.OrderBy(kvp => kvp.Key.Length))
                {
                    var innerKey = kvp.Key;
                    var innerValue = kvp.Value;

                    if (innerValue != string.Empty)
                    {
                        Console.WriteLine($"{keysCount}. {innerKey} - {innerValue}");

                        keysCount++;
                    }
                }

                foreach (var kvp in innerValues)
                {
                    var innerKey = kvp.Key;
                    var innerValue = kvp.Value;

                    if (innerValue == string.Empty)
                    {
                        Console.WriteLine($"{keysCount}. {innerKey}");

                        keysCount++;
                    }
                }

                keysCount = 1;
            }
        }
    }
}