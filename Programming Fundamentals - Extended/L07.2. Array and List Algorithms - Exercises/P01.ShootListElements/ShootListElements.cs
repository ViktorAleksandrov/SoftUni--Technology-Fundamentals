namespace P01.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShootListElements
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var survivors = new List<int>();

            var lastRemovedNumber = 0;

            while (input != "stop")
            {
                if (input == "bang")
                {
                    if (survivors.Count == 0)
                    {
                        Console.WriteLine(
                            $"nobody left to shoot! last one was {lastRemovedNumber}");

                        return;
                    }

                    var average = survivors.Average();

                    for (var index = 0; index < survivors.Count; index++)
                    {
                        if (survivors[index] < average || survivors.Count == 1)
                        {
                            lastRemovedNumber = survivors[index];

                            Console.WriteLine($"shot {lastRemovedNumber}");

                            survivors.Remove(survivors[index]);

                            for (var cnt = 0; cnt < survivors.Count; cnt++)
                            {
                                survivors[cnt]--;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    var number = int.Parse(input);

                    survivors.Insert(0, number);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(survivors.Count > 0
                ? $"survivors: {string.Join(" ", survivors)}"
                : $"you shot them all. last one was {lastRemovedNumber}");
        }
    }
}