namespace P09.TriangleFormations
{
    using System;

    public class TriangleFormations
    {
        public static void Main()
        {
            var firstSide = int.Parse(Console.ReadLine());
            var secondSide = int.Parse(Console.ReadLine());
            var thirdSide = int.Parse(Console.ReadLine());

            if ((firstSide + secondSide <= thirdSide)
                || (firstSide + thirdSide <= secondSide)
                || (secondSide + thirdSide <= firstSide))
            {
                Console.WriteLine("Invalid Triangle.");

                return;
            }

            Console.WriteLine("Triangle is valid.");

            if ((firstSide * firstSide) + (secondSide * secondSide) == (thirdSide * thirdSide))
            {
                Console.WriteLine(
                    "Triangle has a right angle between sides a and b");
            }
            else if ((firstSide * firstSide) + (thirdSide * thirdSide) == (secondSide * secondSide))
            {
                Console.WriteLine(
                    "Triangle has a right angle between sides a and c");
            }
            else if ((secondSide * secondSide) + (thirdSide * thirdSide) == (firstSide * firstSide))
            {
                Console.WriteLine(
                    "Triangle has a right angle between sides b and c");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}