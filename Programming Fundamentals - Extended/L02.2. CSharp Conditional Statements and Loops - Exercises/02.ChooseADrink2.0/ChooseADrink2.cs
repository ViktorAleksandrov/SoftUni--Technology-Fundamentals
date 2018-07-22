using System;

class ChooseADrink2
{
    static void Main()
    {
        string profession = Console.ReadLine();
        int drinkQuantity = int.Parse(Console.ReadLine());

        double drinkPrice = 0.00;

        switch (profession)
        {
            case "Athlete":
                drinkPrice = 0.70;
                break;
            case "Businessman":
            case "Businesswoman":
                drinkPrice = 1.00;
                break;
            case "SoftUni Student":
                drinkPrice = 1.70;
                break;
            default:
                drinkPrice = 1.20;
                break;
        }

        double totalPrice = drinkQuantity * drinkPrice;

        Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
    }
}