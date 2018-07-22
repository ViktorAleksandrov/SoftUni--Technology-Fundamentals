namespace P04.GroupContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            var continentsData =
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (var index = 0; index < linesCount; index++)
            {
                var inputLine = Console.ReadLine().Split();

                var continent = inputLine[0];
                var country = inputLine[1];
                var city = inputLine[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new SortedSet<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (var continent in continentsData.Keys)
            {
                Console.WriteLine($"{continent}:");

                var countriesData = continentsData[continent];

                foreach (var country in countriesData.Keys)
                {
                    var cities = countriesData[country];

                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}