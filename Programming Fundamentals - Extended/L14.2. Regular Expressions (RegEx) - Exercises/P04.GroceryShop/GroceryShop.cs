namespace P04.GroceryShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class GroceryShop
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"^[A-Z][a-z]+:\d+\.\d{2}$");

            var productsData = new Dictionary<string, double>();

            while (input != "bill")
            {
                if (regex.IsMatch(input))
                {
                    var inputTokens = input.Split(':');

                    var product = inputTokens[0];
                    var price = double.Parse(inputTokens[1]);

                    productsData[product] = price;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in productsData.OrderByDescending(kvp => kvp.Value))
            {
                var product = kvp.Key;
                var price = kvp.Value;

                Console.WriteLine($"{product} costs {price:f2}");
            }
        }
    }
}