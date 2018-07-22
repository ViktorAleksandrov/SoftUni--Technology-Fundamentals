namespace P07.SalesReport
{
    using System;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            var sales = ReadSales();

            var towns = sales
                .Select(s => s.Town)
                .Distinct()
                .OrderBy(s => s);

            foreach (var town in towns)
            {
                var salesByTown = sales
                    .Where(s => s.Town == town)
                    .Select(s => s.Price * s.Quantity)
                    .Sum();

                Console.WriteLine($"{town} -> {salesByTown:f2}");
            }
        }

        public static Sale[] ReadSales()
        {
            var salesCount = int.Parse(Console.ReadLine());

            var sales = new Sale[salesCount];

            for (var index = 0; index < salesCount; index++)
            {
                var inputLine = Console.ReadLine().Split();

                sales[index] = new Sale
                {
                    Town = inputLine[0],
                    Price = decimal.Parse(inputLine[2]),
                    Quantity = decimal.Parse(inputLine[3])
                };
            }

            return sales;
        }

        public class Sale
        {
            public string Town { get; set; }

            public decimal Price { get; set; }

            public decimal Quantity { get; set; }
        }
    }
}