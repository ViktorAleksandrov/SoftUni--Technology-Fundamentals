namespace P03.Camping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Camping
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split();

            var campingData =
                new Dictionary<string, Dictionary<string, int>>();

            while (inputLine[0] != "end")
            {
                var name = inputLine[0];
                var camper = inputLine[1];
                var nights = int.Parse(inputLine[2]);

                if (!campingData.ContainsKey(name))
                {
                    campingData[name] = new Dictionary<string, int>();
                }

                if (!campingData[name].ContainsKey(camper))
                {
                    campingData[name][camper] = 0;
                }

                campingData[name][camper] += nights;

                inputLine = Console.ReadLine().Split();
            }

            var orderedCampingData = campingData
                .OrderByDescending(c => c.Value.Count)
                .ThenBy(kvp => kvp.Key.Length);

            foreach (var kvp in orderedCampingData)
            {
                var name = kvp.Key;
                var campersData = kvp.Value;
                var campersCount = campersData.Count();

                Console.WriteLine($"{name}: {campersCount}");

                foreach (var pair in campersData)
                {
                    var camperModel = pair.Key;

                    Console.WriteLine($"***{camperModel}");
                }

                var totalNights = campersData.Values.Sum();

                Console.WriteLine($"Total stay: {totalNights} nights");
            }
        }
    }
}