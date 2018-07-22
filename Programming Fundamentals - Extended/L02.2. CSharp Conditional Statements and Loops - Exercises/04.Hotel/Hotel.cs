using System;

class Hotel
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPricePerNight = 0.00;
        double doublePricePerNight = 0.00;
        double suitePricePerNight = 0.00;

        switch (month)
        {
            case "May":
            case "October":
                studioPricePerNight = 50.00;
                doublePricePerNight = 65.00;
                suitePricePerNight = 75.00;

                if (nights > 7)
                {
                    studioPricePerNight *= 0.95;
                }

                break;

            case "June":
            case "September":
                studioPricePerNight = 60.00;
                doublePricePerNight = 72.00;
                suitePricePerNight = 82.00;

                if (nights > 14)
                {
                    doublePricePerNight *= 0.90;
                }

                break;

            case "July":
            case "August":
            case "December":
                studioPricePerNight = 68.00;
                doublePricePerNight = 77.00;
                suitePricePerNight = 89.00;

                if (nights > 14)
                {
                    suitePricePerNight *= 0.85;
                }

                break;
        }

        double totalStudioPrice = studioPricePerNight * nights;
        double totalDoublePrice = doublePricePerNight * nights;
        double totalSuitePrice = suitePricePerNight * nights;

        if (nights > 7 && (month == "September" || month == "October"))
        {
            totalStudioPrice -= studioPricePerNight;
        }

        Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
        Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
    }
}