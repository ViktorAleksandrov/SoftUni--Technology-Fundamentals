namespace P06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Batteries
    {
        public static void Main()
        {
            var capacities = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var drainsPerHour = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var testHours = int.Parse(Console.ReadLine());

            var remainingCapacities = new List<double>();

            for (var index = 0; index < capacities.Count; index++)
            {
                var capacity = capacities[index];
                var drain = drainsPerHour[index];

                if (capacity - (drain * testHours) > 0)
                {
                    remainingCapacities.Add(capacity - (drain * testHours));
                }
                else
                {
                    remainingCapacities.Add(Math.Ceiling(capacity / drain));
                }
            }

            for (var cnt = 0; cnt < capacities.Count; cnt++)
            {
                var capacity = capacities[cnt];
                var drain = drainsPerHour[cnt];
                var remainCapacity = remainingCapacities[cnt];
                var initialCapacity = capacities[cnt];

                if (capacity - (drain * testHours) > 0)
                {
                    var percentage = remainCapacity / initialCapacity * 100;

                    Console.WriteLine(
                        $"Battery {cnt + 1}: {remainCapacity:f2} mAh ({percentage:f2})%");
                }
                else
                {
                    Console.WriteLine(
                        $"Battery {cnt + 1}: dead (lasted {remainCapacity} hours)");
                }
            }
        }
    }
}