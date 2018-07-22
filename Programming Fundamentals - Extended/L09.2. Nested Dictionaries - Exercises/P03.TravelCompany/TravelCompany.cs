namespace P03.TravelCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TravelCompany
    {
        public static void Main()
        {
            var cityPackage = Console.ReadLine().Split(':');

            var holidayPackages = new Dictionary<string, Dictionary<string, int>>();

            while (cityPackage[0] != "ready")
            {
                var city = cityPackage[0];

                if (!holidayPackages.ContainsKey(city))
                {
                    holidayPackages[city] = new Dictionary<string, int>();
                }

                var allVehiclesData = cityPackage[1].Split(',');

                foreach (var vehicleData in allVehiclesData)
                {
                    var currentVehicleData = vehicleData.Split('-');

                    var vehicle = currentVehicleData[0];
                    var capacity = int.Parse(currentVehicleData[1]);

                    if (!holidayPackages[city].ContainsKey(vehicle))
                    {
                        holidayPackages[city][vehicle] = 0;
                    }

                    holidayPackages[city][vehicle] = capacity;
                }

                cityPackage = Console.ReadLine().Split(':');
            }

            var group = Console.ReadLine();

            while (group != "travel time!")
            {
                var groupInfo = group.Split();

                var city = groupInfo[0];
                var peopleCount = int.Parse(groupInfo[1]);

                var totalCapacity = holidayPackages[city].Values.Sum();

                Console.WriteLine(peopleCount <= totalCapacity
                    ? $"{city} -> all {peopleCount} accommodated"
                    : $"{city} -> all except {peopleCount - totalCapacity} accommodated");

                group = Console.ReadLine();
            }
        }
    }
}