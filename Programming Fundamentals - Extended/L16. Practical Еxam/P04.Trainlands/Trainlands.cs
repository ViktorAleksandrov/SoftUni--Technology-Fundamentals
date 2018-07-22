namespace P04.Trainlands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainlands
    {
        public static void Main()
        {
            var trainsWagonsPowers = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                var inputTokens = input.Split();

                var train = inputTokens[0];
                var delimiter = inputTokens[1];

                if (inputTokens.Length == 5)
                {
                    var wagonName = inputTokens[2];
                    var wagonPower = int.Parse(inputTokens[4]);

                    if (!trainsWagonsPowers.ContainsKey(train))
                    {
                        trainsWagonsPowers[train] = new Dictionary<string, int>();
                    }

                    trainsWagonsPowers[train][wagonName] = wagonPower;
                }
                else if (delimiter == "->")
                {
                    var otherTrain = inputTokens[2];

                    if (!trainsWagonsPowers.ContainsKey(train))
                    {
                        trainsWagonsPowers[train] = new Dictionary<string, int>();
                    }

                    foreach (var kvp in trainsWagonsPowers[otherTrain])
                    {
                        trainsWagonsPowers[train].Add(kvp.Key, kvp.Value);
                    }

                    trainsWagonsPowers.Remove(otherTrain);
                }
                else
                {
                    var otherTrain = inputTokens[2];

                    if (!trainsWagonsPowers.ContainsKey(train))
                    {
                        trainsWagonsPowers[train] = new Dictionary<string, int>();
                    }

                    trainsWagonsPowers[train].Clear();

                    foreach (var kvp in trainsWagonsPowers[otherTrain])
                    {
                        trainsWagonsPowers[train].Add(kvp.Key, kvp.Value);
                    }
                }

                input = Console.ReadLine();
            }

            var orderedTrainWagonsPowers = trainsWagonsPowers
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ThenBy(kvp => kvp.Value.Count);

            foreach (var kvp in orderedTrainWagonsPowers)
            {
                var train = kvp.Key;

                Console.WriteLine($"Train: {train}");

                var wagonsPowers = kvp.Value;

                foreach (var pair in wagonsPowers.OrderByDescending(pair => pair.Value))
                {
                    var wagonName = pair.Key;
                    var wagonPower = pair.Value;

                    Console.WriteLine($"###{wagonName} - {wagonPower}");
                }
            }
        }
    }
}