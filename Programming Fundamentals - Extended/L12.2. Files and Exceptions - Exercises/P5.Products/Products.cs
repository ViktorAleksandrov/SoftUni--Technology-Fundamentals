namespace P5.Products
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Products
    {
        public static void Main()
        {
            if (!File.Exists("Stocked Products.txt"))
            {
                File.Create("Stocked Products.txt").Close();
            }

            var stockedProductsData = File.ReadAllLines("Stocked Products.txt");

            var productsData = new List<Product>();

            foreach (var productData in stockedProductsData)
            {
                var productDataParams = productData.Split();

                var name = productDataParams[0];
                var type = productDataParams[1];
                var price = decimal.Parse(productDataParams[2]);
                var quantity = int.Parse(productDataParams[3]);

                productsData.Add(new Product(name, type, price, quantity));
            }

            var input = Console.ReadLine();

            while (input != "exit")
            {
                var inputParams = input.Split();

                var command = inputParams[0];

                if (inputParams.Length > 1)
                {
                    var name = inputParams[0];
                    var type = inputParams[1];
                    var price = decimal.Parse(inputParams[2]);
                    var quantity = int.Parse(inputParams[3]);

                    var hasChanged = false;

                    foreach (var product in productsData)
                    {
                        if (product.Type == type && product.Name == name)
                        {
                            product.Price = price;
                            product.Quantity = quantity;

                            hasChanged = true;
                        }
                    }

                    if (!hasChanged)
                    {
                        productsData.Add(new Product(name, type, price, quantity));
                    }
                }
                else if (command == "stock")
                {
                    var stockedProducts = productsData
                        .Select(p => $"{p.Name} {p.Type} {p.Price} {p.Quantity}");

                    File.WriteAllLines("Stocked Products.txt", stockedProducts);
                }
                else if (command == "analyze")
                {
                    var productsDatabase = File.ReadAllLines("Stocked Products.txt");

                    var stockedProducts = new List<Product>();

                    if (productsDatabase.Any())
                    {
                        foreach (var productData in productsDatabase)
                        {
                            var productDataParams = productData.Split();

                            var name = productDataParams[0];
                            var type = productDataParams[1];
                            var price = decimal.Parse(productDataParams[2]);
                            var quantity = int.Parse(productDataParams[3]);

                            stockedProducts.Add(new Product(name, type, price, quantity));
                        }

                        foreach (var product in stockedProducts.OrderBy(p => p.Type))
                        {
                            Console.WriteLine($"{product.Type}, Product: {product.Name}");
                            Console.WriteLine(
                                $"Price: ${product.Price}, Amount Left: {product.Quantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No products stocked");
                    }
                }
                else
                {
                    var foodIncome = productsData
                        .Where(p => p.Type == "Food")
                        .Sum(p => p.Income);

                    var electronicsIncome = productsData
                        .Where(p => p.Type == "Electronics")
                        .Sum(p => p.Income);

                    var domesticsIncome = productsData
                        .Where(p => p.Type == "Domestics")
                        .Sum(p => p.Income);

                    var typesIncomes = new Dictionary<string, decimal>
                    {
                        ["Food"] = foodIncome,
                        ["Electronics"] = electronicsIncome,
                        ["Domestics"] = domesticsIncome
                    };

                    foreach (var kvp in typesIncomes.OrderByDescending(kvp => kvp.Value))
                    {
                        var type = kvp.Key;
                        var income = kvp.Value;

                        if (income != 0)
                        {
                            Console.WriteLine($"{type}: ${income:f2}");
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        public class Product
        {
            public Product(string name, string type, decimal price, int quantity)
            {
                this.Name = name;
                this.Type = type;
                this.Price = price;
                this.Quantity = quantity;
            }

            public string Name { get; set; }

            public string Type { get; set; }

            public decimal Price { get; set; }

            public int Quantity { get; set; }

            public decimal Income => this.Price * this.Quantity;
        }
    }
}