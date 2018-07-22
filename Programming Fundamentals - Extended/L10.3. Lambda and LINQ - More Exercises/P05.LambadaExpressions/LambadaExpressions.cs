namespace P05.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { " => " }, StringSplitOptions.None);

            var lambadaExpressions = new Dictionary<string, string>();

            while (inputLine[0] != "lambada")
            {
                var selector = inputLine[0];

                if (selector != "dance")
                {
                    var propety = inputLine[1];

                    lambadaExpressions[selector] = propety;
                }
                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Key + "." + kvp.Value);
                }

                inputLine = Console.ReadLine()
                    .Split(new[] { " => " }, StringSplitOptions.None);
            }

            foreach (var selector in lambadaExpressions.Keys)
            {
                var property = lambadaExpressions[selector];

                Console.WriteLine($"{selector} => {property}");
            }
        }
    }
}