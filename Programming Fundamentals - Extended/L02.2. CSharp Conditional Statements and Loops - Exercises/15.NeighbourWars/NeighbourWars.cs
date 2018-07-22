using System;

class NeighbourWars
{
    static void Main()
    {
        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());

        int round = 1;

        int peshoHealth = 100;
        int goshoHealth = 100;

        while (peshoHealth > 0 || goshoHealth > 0)
        {
            if (round % 2 == 1)
            {
                goshoHealth -= peshoDamage;

                if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;
                }

                Console.WriteLine(
                    $"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }
            else
            {
                peshoHealth -= goshoDamage;

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }

                Console.WriteLine(
                    $"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }

            if (round % 3 == 0)
            {
                peshoHealth += 10;
                goshoHealth += 10;
            }

            round++;
        }
    }
}