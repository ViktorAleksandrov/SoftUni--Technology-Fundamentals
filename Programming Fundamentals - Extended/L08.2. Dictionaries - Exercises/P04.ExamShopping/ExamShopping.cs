namespace P04.ExamShopping
{
    using System;
    using System.Collections.Generic;

    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var productsQuantitites = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var inventory = input.Split();

                var product = inventory[1];
                var quantity = int.Parse(inventory[2]);

                if (inventory[0] == "stock")
                {
                    if (!productsQuantitites.ContainsKey(product))
                    {
                        productsQuantitites.Add(product, 0);
                    }

                    productsQuantitites[product] += quantity;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "exam time")
            {
                var purchase = input.Split();

                var product = purchase[1];
                var quantity = int.Parse(purchase[2]);

                if (purchase[0] == "buy")
                {
                    if (!productsQuantitites.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                    else if (productsQuantitites.ContainsKey(product))
                    {
                        if (productsQuantitites[product] == 0)
                        {
                            Console.WriteLine($"{product} out of stock");
                        }
                        else if (quantity > productsQuantitites[product])
                        {
                            productsQuantitites[product] = 0;
                        }
                        else
                        {
                            productsQuantitites[product] -= quantity;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var product in productsQuantitites.Keys)
            {
                var quantity = productsQuantitites[product];

                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}