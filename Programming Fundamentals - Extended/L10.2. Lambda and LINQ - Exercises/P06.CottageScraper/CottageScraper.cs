namespace P06.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var treesHeights = new List<KeyValuePair<string, int>>();

            while (input != "chop chop")
            {
                var inputParams = input
                    .Split(new[] { " -> " }, StringSplitOptions.None);

                var tree = inputParams[0];
                var height = int.Parse(inputParams[1]);

                treesHeights.Add(new KeyValuePair<string, int>(tree, height));

                input = Console.ReadLine();
            }

            var cottageScraperTree = Console.ReadLine();
            var minHeight = int.Parse(Console.ReadLine());

            var pricePerMeter = Math.Round(treesHeights.Average(kvp => kvp.Value), 2);

            double usedTreesPrice = treesHeights
                .Where(kvp => kvp.Key == cottageScraperTree && kvp.Value >= minHeight)
                .Sum(kvp => kvp.Value);

            double unusedTreesPrice = treesHeights
                .Where(kvp => kvp.Key != cottageScraperTree || kvp.Value < minHeight)
                .Sum(kvp => kvp.Value);

            usedTreesPrice = Math.Round(usedTreesPrice * pricePerMeter, 2);
            unusedTreesPrice = Math.Round(unusedTreesPrice * pricePerMeter * 0.25, 2);

            var totalPrice = usedTreesPrice + unusedTreesPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}\n"
                            + $"Used logs price: ${usedTreesPrice:f2}\n"
                            + $"Unused logs price: ${unusedTreesPrice:f2}\n"
                            + $"CottageScraper subtotal: ${totalPrice:f2}");
        }
    }
}