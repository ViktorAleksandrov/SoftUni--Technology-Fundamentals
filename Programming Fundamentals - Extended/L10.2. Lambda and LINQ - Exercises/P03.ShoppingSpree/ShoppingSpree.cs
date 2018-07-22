namespace P03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingSpree
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());

            var inputLine = Console.ReadLine().Split();

            var productsPrices = new Dictionary<string, double>();

            while (inputLine[0] != "end")
            {
                var product = inputLine[0];
                var price = double.Parse(inputLine[1]);

                if (!productsPrices.ContainsKey(product))
                {
                    productsPrices[product] = price;
                }
                else if (price < productsPrices[product])
                {
                    productsPrices[product] = price;
                }

                inputLine = Console.ReadLine().Split();
            }

            var sum = productsPrices.Values.Sum();

            if (sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                productsPrices
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key.Length)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"{p.Key} costs {p.Value:f2}"));
            }
        }
    }
}