namespace P04.SoftUniBeerPong
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniBeerPong
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var teamsData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "stop the game")
            {
                var inputParams = input.Split('|');

                var team = inputParams[1];
                var player = inputParams[0];
                var points = int.Parse(inputParams[2]);

                if (!teamsData.ContainsKey(team))
                {
                    teamsData[team] = new Dictionary<string, int>();
                }

                if (teamsData[team].Count < 3)
                {
                    teamsData[team][player] = points;
                }

                input = Console.ReadLine();
            }

            var orderedTeamsData = teamsData
                .Where(t => t.Value.Count == 3)
                .OrderByDescending(t => t.Value.Sum(kvp => kvp.Value));

            var teamRank = 0;

            foreach (var pair in orderedTeamsData)
            {
                teamRank++;

                var team = pair.Key;

                Console.WriteLine($"{teamRank}. {team}; Players:");

                var playersPoints = pair.Value;

                foreach (var kvp in playersPoints.OrderByDescending(kvp => kvp.Value))
                {
                    var player = kvp.Key;
                    var points = kvp.Value;

                    Console.WriteLine($"###{player}: {points}");
                }
            }
        }
    }
}