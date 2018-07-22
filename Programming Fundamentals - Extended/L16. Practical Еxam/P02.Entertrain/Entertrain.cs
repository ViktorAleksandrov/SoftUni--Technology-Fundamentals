namespace P02.Entertrain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Entertrain
    {
        public static void Main()
        {
            var locomotivePower = int.Parse(Console.ReadLine());

            var wagons = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "All ofboard!")
                {
                    break;
                }

                var wagonWeight = int.Parse(input);

                wagons.Add(wagonWeight);

                if (wagons.Sum() > locomotivePower)
                {
                    var average = (int)wagons.Average();

                    var closestWagon = wagons
                        .OrderBy(wagon => Math.Abs(average - wagon))
                        .First();

                    wagons.Remove(closestWagon);
                }
            }

            wagons.Reverse();
            wagons.Add(locomotivePower);

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}