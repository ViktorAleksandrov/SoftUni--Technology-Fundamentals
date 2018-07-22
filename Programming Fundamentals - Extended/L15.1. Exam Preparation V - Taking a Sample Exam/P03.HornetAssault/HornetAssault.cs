namespace P03.HornetAssault
{
    using System;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            var hornetsPower = hornets.Sum();

            for (var index = 0; index < beehives.Count; index++)
            {
                if (!hornets.Any())
                {
                    break;
                }

                if (hornetsPower > beehives[index])
                {
                    beehives.RemoveAt(index);

                    index--;
                }
                else
                {
                    beehives[index] -= hornetsPower;

                    if (beehives[index] == 0)
                    {
                        beehives.RemoveAt(index);

                        index--;
                    }

                    hornets.RemoveAt(0);

                    hornetsPower = hornets.Sum();
                }
            }

            Console.WriteLine(beehives.Any()
                ? string.Join(" ", beehives)
                : string.Join(" ", hornets));
        }
    }
}