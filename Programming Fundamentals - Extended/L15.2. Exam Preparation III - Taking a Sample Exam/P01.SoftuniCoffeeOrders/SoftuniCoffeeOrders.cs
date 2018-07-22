namespace P01.SoftuniCoffeeOrders
{
    using System;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var ordersCount = int.Parse(Console.ReadLine());

            var totalPrice = 0M;

            for (var index = 0; index < ordersCount; index++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());

                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var capsulesCount = int.Parse(Console.ReadLine());

                var price = daysInMonth * capsulePrice * capsulesCount;

                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}