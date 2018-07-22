namespace P05.ClosestTwoPoints
{
    using System;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var inputPoints = ReadPoints();

            var closestPoints = FindClosestTwoPoints(inputPoints);

            PrintDistance(closestPoints);

            var firstPoint = closestPoints[0];
            var secondPoint = closestPoints[1];

            PrintPoint(firstPoint);
            PrintPoint(secondPoint);
        }

        public static Point[] ReadPoints()
        {
            var pointsCount = int.Parse(Console.ReadLine());

            var points = new Point[pointsCount];

            for (var index = 0; index < pointsCount; index++)
            {
                points[index] = ReadPoint();
            }

            return points;
        }

        public static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;

            var closestTwoPoints = new Point[2];

            for (var point1 = 0; point1 < points.Length; point1++)
            {
                for (var point2 = point1 + 1; point2 < points.Length; point2++)
                {
                    var firstPoint = points[point1];
                    var secondPoint = points[point2];

                    var distance = CalcDistance(firstPoint, secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;

                        closestTwoPoints[0] = firstPoint;
                        closestTwoPoints[1] = secondPoint;
                    }
                }
            }

            return closestTwoPoints;
        }

        public static void PrintDistance(Point[] closestPoints)
        {
            var firstPoint = closestPoints[0];
            var secondPoint = closestPoints[1];

            var distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        public static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        public static Point ReadPoint()
        {
            var pointCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var x = pointCoordinates[0];
            var y = pointCoordinates[1];

            return new Point(x, y);
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
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
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}