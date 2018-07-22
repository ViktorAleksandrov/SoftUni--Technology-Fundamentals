namespace P04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        private static Point ReadPoint()
        {
            var pointCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var x = pointCoordinates[0];
            var y = pointCoordinates[1];

            return new Point(x, y);
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var sideA = firstPoint.X - secondPoint.X;
            var sideB = firstPoint.Y - secondPoint.Y;

            var distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }

        public class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}