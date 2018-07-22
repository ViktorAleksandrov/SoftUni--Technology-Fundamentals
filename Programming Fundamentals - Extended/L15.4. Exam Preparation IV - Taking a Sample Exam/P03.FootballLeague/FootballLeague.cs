namespace P03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FootballLeague
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());

            var teamRegex = new Regex($@"(?<={key})[a-zA-Z]*(?={key})");

            var input = Console.ReadLine();

            var scoreRegex = new Regex(@"(\d+:\d+)");

            var teamsPoints = new SortedDictionary<string, int>();
            var teamsGoals = new SortedDictionary<string, int>();

            while (input != "final")
            {
                var teams = teamRegex
                    .Matches(input)
                    .Cast<Match>()
                    .ToArray();

                var firstTeam = new string(teams[0]
                    .Value
                    .ToUpper()
                    .Reverse()
                    .ToArray());

                var secondTeam = new string(teams[1]
                    .Value
                    .ToUpper()
                    .Reverse()
                    .ToArray());

                var score = scoreRegex
                    .Match(input)
                    .Value
                    .Split(':');

                var firstTeamGoals = int.Parse(score[0]);
                var secondTeamGoals = int.Parse(score[1]);

                if (!teamsPoints.ContainsKey(firstTeam))
                {
                    teamsPoints[firstTeam] = 0;
                    teamsGoals[firstTeam] = 0;
                }

                if (!teamsPoints.ContainsKey(secondTeam))
                {
                    teamsPoints[secondTeam] = 0;
                    teamsGoals[secondTeam] = 0;
                }

                teamsGoals[firstTeam] += firstTeamGoals;
                teamsGoals[secondTeam] += secondTeamGoals;

                if (firstTeamGoals > secondTeamGoals)
                {
                    teamsPoints[firstTeam] += 3;
                }
                else if (firstTeamGoals < secondTeamGoals)
                {
                    teamsPoints[secondTeam] += 3;
                }
                else
                {
                    teamsPoints[firstTeam]++;
                    teamsPoints[secondTeam]++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            var place = 1;

            foreach (var teamPoints in teamsPoints.OrderByDescending(kvp => kvp.Value))
            {
                var team = teamPoints.Key;
                var points = teamPoints.Value;

                Console.WriteLine($"{place++}. {team} {points}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var teamGoals in teamsGoals.OrderByDescending(kvp => kvp.Value).Take(3))
            {
                var team = teamGoals.Key;
                var goals = teamGoals.Value;

                Console.WriteLine($"- {team} -> {goals}");
            }
        }
    }
}