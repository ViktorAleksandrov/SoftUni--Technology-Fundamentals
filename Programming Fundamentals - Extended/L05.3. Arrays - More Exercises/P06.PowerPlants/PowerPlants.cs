namespace P06.PowerPlants
{
    using System;
    using System.Linq;

    public class PowerPlants
    {
        public static void Main()
        {
            var plantsPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var daysInSeason = plantsPower.Length;
            var daysCount = 0;

            while (true)
            {
                for (var index = 0; index < daysInSeason; index++)
                {
                    var currentPlantPower = plantsPower[index];
                    var currentDay = daysCount % daysInSeason;

                    if (currentPlantPower > 0 && index != currentDay)
                    {
                        plantsPower[index]--;
                    }
                }

                if (plantsPower.Max() > 0)
                {
                    daysCount++;

                    if (daysCount % daysInSeason == 0)
                    {
                        for (var cnt = 0; cnt < daysInSeason; cnt++)
                        {
                            var currentPlantPower = plantsPower[cnt];

                            if (currentPlantPower > 0)
                            {
                                plantsPower[cnt]++;
                            }
                        }
                    }
                }
                else
                {
                    daysCount++;

                    var seasons = (daysCount - 1) / daysInSeason;

                    var seasonText = seasons == 1
                        ? "season"
                        : "seasons";

                    Console.WriteLine(
                        $"survived {daysCount} days ({seasons} {seasonText})");

                    return;
                }
            }
        }
    }
}