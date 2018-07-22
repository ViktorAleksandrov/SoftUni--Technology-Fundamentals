namespace P18.BallisticsTraining
{
    using System;
    using System.Linq;

    public class BallisticsTraining
    {
        private static void Main()
        {
            var planeCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firingDirections = Console.ReadLine().Split();

            var gunCoordinates = new[] { 0, 0 };

            var gunXCoordinate = gunCoordinates[0];
            var gunYCoordinate = gunCoordinates[1];

            for (var index = 0; index < firingDirections.Length - 1; index += 2)
            {
                var currentDirection = firingDirections[index];

                var directionValue = int.Parse(firingDirections[index + 1]);

                switch (currentDirection)
                {
                    case "up":
                        gunYCoordinate += directionValue;
                        break;
                    case "down":
                        gunYCoordinate -= directionValue;
                        break;
                    case "left":
                        gunXCoordinate -= directionValue;
                        break;
                    case "right":
                        gunXCoordinate += directionValue;
                        break;
                }
            }

            Console.WriteLine($"firing at [{gunXCoordinate}, {gunYCoordinate}]");

            var planeXCoordinate = planeCoordinates[0];
            var planeYCoordinate = planeCoordinates[1];

            if (gunXCoordinate == planeXCoordinate && gunYCoordinate == planeYCoordinate)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}