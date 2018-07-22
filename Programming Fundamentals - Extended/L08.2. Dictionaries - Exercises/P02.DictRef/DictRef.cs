namespace P02.DictRef
{
    using System;
    using System.Collections.Generic;

    public class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var refDict = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                var firstName = input[0];

                if (int.TryParse(input[2], out var currentValue))
                {
                    refDict[firstName] = currentValue;
                }
                else
                {
                    var secondName = input[2];

                    if (refDict.ContainsKey(secondName))
                    {
                        var secondNameValue = refDict[secondName];

                        refDict[firstName] = secondNameValue;
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach (var name in refDict.Keys)
            {
                var value = refDict[name];

                Console.WriteLine($"{name} === {value}");
            }
        }
    }
}