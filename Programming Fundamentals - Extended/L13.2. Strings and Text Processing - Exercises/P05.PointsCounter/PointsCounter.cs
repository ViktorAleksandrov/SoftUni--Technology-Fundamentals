namespace P05.PointsCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PointsCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var teamData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Result")
            {
                var inputLine = input
                    .Replace("@", string.Empty)
                    .Replace("%", string.Empty)
                    .Replace("$", string.Empty)
                    .Replace("*", string.Empty)
                    .Split('|');

                var team = string.Empty;
                var player = string.Empty;

                if (char.IsUpper(inputLine[0].Last()))
                {
                    team = inputLine[0];
                    player = inputLine[1];
                }
                else
                {
                    team = inputLine[1];
                    player = inputLine[0];
                }

                if (!teamData.ContainsKey(team))
                {
                    teamData[team] = new Dictionary<string, int>();
                }

                var points = int.Parse(inputLine[2]);

                teamData[team][player] = points;

                input = Console.ReadLine();
            }

            var orderedTeamData = teamData
                .OrderByDescending(kvp => kvp.Value.Values.Sum());

            foreach (var kvp in orderedTeamData)
            {
                var team = kvp.Key;
                var totalPoints = kvp.Value.Values.Sum();

                Console.WriteLine($"{team} => {totalPoints}");

                var playerData = kvp.Value
                    .OrderByDescending(pair => pair.Value)
                    .First();

                var player = playerData.Key;

                Console.WriteLine($"Most points scored by {player}");
            }
        }
    }
}