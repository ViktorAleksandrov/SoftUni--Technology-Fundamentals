using System;

class RestaurantDiscount
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string servicePackage = Console.ReadLine();

        if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        string hallType = string.Empty;
        int hallPrice = 0;

        if (groupSize <= 50)
        {
            hallType = "Small Hall";
            hallPrice = 2500;
        }
        else if (groupSize <= 100)
        {
            hallType = "Terrace";
            hallPrice = 5000;
        }
        else
        {
            hallType = "Great Hall";
            hallPrice = 7500;
        }

        double totalPrice = 0.00;

        switch (servicePackage)
        {
            case "Normal":
                totalPrice = (hallPrice + 500) * 0.95;
                break;
            case "Gold":
                totalPrice = (hallPrice + 750) * 0.90;
                break;
            case "Platinum":
                totalPrice = (hallPrice + 1000) * 0.85;
                break;
        }

        double pricePerPerson = totalPrice / groupSize;

        Console.WriteLine($"We can offer you the {hallType}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }
}