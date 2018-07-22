namespace P07.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LINQuistics
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ".", "()" }, StringSplitOptions.RemoveEmptyEntries);

            var collectionsMethods = new Dictionary<string, HashSet<string>>();

            while (inputLine[0] != "exit")
            {
                var collection = inputLine[0];

                if (inputLine.Length == 1)
                {
                    if (collection.Any(char.IsLetter))
                    {
                        if (collectionsMethods.ContainsKey(collection))
                        {
                            var orderedCollection = collectionsMethods[collection]
                                .OrderByDescending(m => m.Length)
                                .ThenByDescending(m => m.Distinct().Count());

                            foreach (var method in orderedCollection)
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }
                    else
                    {
                        var mostMethodsCollection = collectionsMethods
                            .OrderByDescending(kvp => kvp.Value.Count)
                            .Take(1);

                        foreach (var kvp in mostMethodsCollection)
                        {
                            var methods = kvp.Value
                                .OrderBy(m => m.Length)
                                .Take(int.Parse(collection));

                            foreach (var method in methods)
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }
                }
                else
                {
                    var methods = inputLine.Skip(1);

                    if (!collectionsMethods.ContainsKey(collection))
                    {
                        collectionsMethods[collection] = new HashSet<string>();
                    }

                    foreach (var method in methods)
                    {
                        collectionsMethods[collection].Add(method);
                    }
                }

                inputLine = Console.ReadLine()
                    .Split(new[] { ".", "()" }, StringSplitOptions.RemoveEmptyEntries);
            }

            var lastInputLine = Console.ReadLine().Split();

            var searchedMethod = lastInputLine[0];
            var selection = lastInputLine[1];

            var filteredCollectionsMethods = collectionsMethods
                 .Where(kvp => kvp.Value.Contains(searchedMethod))
                 .OrderByDescending(kvp => kvp.Value.Count)
                 .ThenByDescending(kvp => kvp.Value.Min(m => m.Length));

            foreach (var kvp in filteredCollectionsMethods)
            {
                var collection = kvp.Key;

                Console.WriteLine(collection);

                if (selection != "all")
                {
                    continue;
                }

                var methods = kvp.Value.OrderByDescending(m => m.Length);

                foreach (var method in methods)
                {
                    Console.WriteLine($"* {method}");
                }
            }
        }
    }
}