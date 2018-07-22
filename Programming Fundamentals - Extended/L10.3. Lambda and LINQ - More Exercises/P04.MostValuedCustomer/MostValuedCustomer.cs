namespace P04.MostValuedCustomer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostValuedCustomer
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var productsPrices = new Dictionary<string, double>();

            while (input != "Shop is open")
            {
                var inputParams = input.Split();

                var product = inputParams[0];
                var price = double.Parse(inputParams[1]);

                productsPrices[product] = price;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var customerData =
                new Dictionary<string, Dictionary<string, double>>();

            var productCount =
                new Dictionary<string, Dictionary<string, int>>();

            while (input != "Print")
            {
                var separators = new[] { ':', ',', ' ' };

                var inputParams = input
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (input != "Discount")
                {
                    var customerName = inputParams[0];

                    if (!customerData.ContainsKey(customerName))
                    {
                        customerData[customerName] = new Dictionary<string, double>();
                        productCount[customerName] = new Dictionary<string, int>();
                    }

                    var products = inputParams
                        .Skip(1)
                        .ToList();

                    foreach (var product in products)
                    {
                        if (!productsPrices.ContainsKey(product))
                        {
                            continue;
                        }

                        if (!productCount[customerName].ContainsKey(product))
                        {
                            productCount[customerName][product] = 0;
                        }

                        productCount[customerName][product]++;
                    }
                }
                else
                {
                    var mostExpensiveProducts = productsPrices
                        .OrderByDescending(kvp => kvp.Value)
                        .Take(3)
                        .ToList();

                    foreach (var productPrice in mostExpensiveProducts)
                    {
                        var product = productPrice.Key;

                        productsPrices[product] *= 0.9;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in productCount)
            {
                var name = kvp.Key;

                var productsData = kvp.Value;

                foreach (var productPrice in productsData)
                {
                    var product = productPrice.Key;
                    var productCnt = productPrice.Value;
                    var price = productsPrices[product];

                    if (!customerData[name].ContainsKey(product))
                    {
                        customerData[name][product] = 0;
                    }

                    customerData[name][product] = price * productCnt;
                }
            }

            var biggestSpender = customerData
                .OrderByDescending(kvp => kvp.Value.Sum(p => p.Value))
                .Take(1)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in productCount)
            {
                var name = kvp.Key;

                var products = kvp.Value;

                foreach (var pair in products)
                {
                    var product = pair.Key;
                    var cnt = pair.Value;

                    if (cnt > 1)
                    {
                        customerData[name][product] /= cnt;
                    }
                }
            }

            foreach (var kvp in biggestSpender)
            {
                var name = kvp.Key;

                Console.WriteLine($"Biggest spender: {name}");
                Console.WriteLine("^Products bought:");

                var products = kvp.Value
                    .OrderByDescending(p => p.Value)
                    .ToDictionary(p => p.Key, p => p.Value);

                var totalSum = 0.0;

                foreach (var pair in products)
                {
                    var product = pair.Key;
                    var price = pair.Value;

                    var productCnt = productCount[name][product];

                    totalSum += price * productCnt;

                    Console.WriteLine($"^^^{product}: {price:f2}");
                }

                Console.WriteLine($"Total: {totalSum:f2}");
            }
        }
    }
}