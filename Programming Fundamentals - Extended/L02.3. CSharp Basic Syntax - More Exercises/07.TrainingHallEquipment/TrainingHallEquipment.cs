using System;

class TrainingHallEquipment
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int numberOfItems = int.Parse(Console.ReadLine());

        double spentMoney = 0.00;

        for (int currentItem = 0; currentItem < numberOfItems; currentItem++)
        {
            string nameOfItem = Console.ReadLine();
            double priceOfItem = double.Parse(Console.ReadLine());
            int quantityOfItem = int.Parse(Console.ReadLine());

            if (quantityOfItem > 1)
            {
                nameOfItem += 's';
            }

            Console.WriteLine($"Adding {quantityOfItem} {nameOfItem} to cart.");

            spentMoney += priceOfItem * quantityOfItem;
        }

        Console.WriteLine($"Subtotal: ${spentMoney:f2}");

        double leftMoney = Math.Abs(budget - spentMoney);

        Console.WriteLine(
            budget >= spentMoney ?
            $"Money left: ${leftMoney:f2}" :
            $"Not enough. We need ${leftMoney:f2} more.");
    }
}