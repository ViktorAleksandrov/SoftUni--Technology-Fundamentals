namespace P05.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { " -> " }, StringSplitOptions.None);

            var dictRef = new Dictionary<string, List<int>>();

            while (input[0] != "end")
            {
                var name = input[0];

                var values = input[1]
                    .Split(new[] { ", " }, StringSplitOptions.None);

                foreach (var value in values)
                {
                    if (int.TryParse(value, out var currentValue))
                    {
                        if (!dictRef.ContainsKey(name))
                        {
                            dictRef[name] = new List<int>();
                        }

                        dictRef[name].Add(currentValue);
                    }
                    else
                    {
                        var otherName = value;

                        if (!dictRef.ContainsKey(otherName))
                        {
                            continue;
                        }

                        if (!dictRef.ContainsKey(name))
                        {
                            dictRef[name] = new List<int>();
                        }

                        dictRef[name].AddRange(dictRef[otherName]);
                    }
                }

                input = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.None);
            }

            foreach (var name in dictRef.Keys)
            {
                var values = dictRef[name];

                Console.WriteLine($"{name} === {string.Join(", ", values)}");
            }
        }
    }
}