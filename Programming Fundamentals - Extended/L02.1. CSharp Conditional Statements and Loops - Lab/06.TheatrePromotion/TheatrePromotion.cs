using System;

class TheatrePromotion
{
    static void Main()
    {
        string dayType = Console.ReadLine();
        int personAge = int.Parse(Console.ReadLine());

        if (personAge < 0 || personAge > 122)
        {
            Console.WriteLine("Error!");
            return;
        }

        int ticketPrice = 0;

        if (personAge <= 18 || personAge > 64)
        {
            if (dayType == "Weekday")
            {
                ticketPrice = 12;
            }
            else if (dayType == "Weekend")
            {
                ticketPrice = 15;
            }
            else if (dayType == "Holiday")
            {
                if (personAge <= 18)
                {
                    ticketPrice = 5;
                }
                else
                {
                    ticketPrice = 10;
                }
            }
        }
        else if (personAge > 18 && personAge <= 64)
        {
            if (dayType == "Weekday")
            {
                ticketPrice = 18;
            }
            else if (dayType == "Weekend")
            {
                ticketPrice = 20;
            }
            else if (dayType == "Holiday")
            {
                ticketPrice = 12;
            }
        }

        Console.WriteLine($"{ticketPrice}$");
    }
}