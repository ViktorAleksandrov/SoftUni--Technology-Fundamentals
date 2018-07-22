namespace P02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var keysValues = new Dictionary<string, string>();

            while (input != "end")
            {
                var inputParams = input
                    .Split(new[] { " -> " }, StringSplitOptions.None);

                var key = inputParams[0];
                var value = inputParams[1];

                keysValues[key] = value;

                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            keysValues
                .Where(p => p.Value != "null")
                .OrderByDescending(p => p.Value.Length)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Key} <-> {p.Value}"));

            keysValues
                .Where(p => p.Value == "null")
                .Select(p => p.Key + " <-> " + defaultValue)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}