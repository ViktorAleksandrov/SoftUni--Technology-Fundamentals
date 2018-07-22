namespace P04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            var legionsActivities = new Dictionary<string, int>();
            var legionsSoldiersData = new Dictionary<string, Dictionary<string, long>>();

            for (var index = 0; index < linesCount; index++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.None);

                var activity = int.Parse(inputLine[0]);
                var legion = inputLine[1];
                var soldierType = inputLine[2];
                var soldierCount = long.Parse(inputLine[3]);

                if (!legionsActivities.ContainsKey(legion))
                {
                    legionsActivities[legion] = activity;
                    legionsSoldiersData[legion] = new Dictionary<string, long>();
                }
                else if (legionsActivities[legion] < activity)
                {
                    legionsActivities[legion] = activity;
                }

                if (!legionsSoldiersData[legion].ContainsKey(soldierType))
                {
                    legionsSoldiersData[legion][soldierType] = 0;
                }

                legionsSoldiersData[legion][soldierType] += soldierCount;
            }

            var command = Console.ReadLine().Split('\\');

            if (command.Length > 1)
            {
                var maxActivity = int.Parse(command[0]);
                var soldierType = command[1];

                var orderedLegionsData = legionsSoldiersData
                    .Where(kvp => kvp.Value.ContainsKey(soldierType))
                    .OrderByDescending(kvp => kvp.Value[soldierType]);

                foreach (var kvp in orderedLegionsData)
                {
                    var legion = kvp.Key;

                    var activity = legionsActivities[legion];

                    var soldierCount = kvp.Value[soldierType];

                    if (maxActivity > activity)
                    {
                        Console.WriteLine($"{legion} -> {soldierCount}");
                    }
                }
            }
            else
            {
                var soldierType = command[0];

                foreach (var kvp in legionsActivities.OrderByDescending(kvp => kvp.Value))
                {
                    var legion = kvp.Key;
                    var activity = kvp.Value;

                    if (legionsSoldiersData[legion].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{activity} : {legion}");
                    }
                }
            }
        }
    }
}