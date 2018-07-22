namespace P01.RegisterUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RegisterUsers
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { " -> " }, StringSplitOptions.None);

            var namesDates = new Dictionary<string, DateTime>();

            while (inputLine[0] != "end")
            {
                var userName = inputLine[0];

                var registryDate =
                    DateTime.ParseExact(inputLine[1], "dd/MM/yyyy", null);

                namesDates[userName] = registryDate;

                inputLine = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.None);
            }

            var orderedUserNames = namesDates
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(d => d.Value)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var username in orderedUserNames.Keys)
            {
                Console.WriteLine(username);
            }
        }
    }
}