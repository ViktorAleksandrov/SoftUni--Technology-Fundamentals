namespace P05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Boxes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputLine = input
                    .Split(new[] { " | " }, StringSplitOptions.None);

                var points = new List<Point>();

                foreach (var point in inputLine)
                {
                    var coordinates = point
                        .Split(':')
                        .Select(int.Parse)
                        .ToList();

                    var firstCoord = coordinates[0];
                    var secondCoord = coordinates[1];

                    points.Add(new Point(firstCoord, secondCoord));
                }

                var upperLeft = points[0];
                var upperRight = points[1];
                var bottomLeft = points[2];
                var bottomRight = points[3];

                var box = new Box(upperLeft, upperRight, bottomLeft, bottomRight);

                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.Perimeter}");
                Console.WriteLine($"Area: {box.Area}");

                input = Console.ReadLine();
            }
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

            public static double CalcDistance(Point firstPoint, Point secondPoint)
            {
                var sideA = firstPoint.X - secondPoint.X;
                var sideB = firstPoint.Y - secondPoint.Y;

                return Math.Sqrt((sideA * sideA) + (sideB * sideB));
            }
        }

        public class Box
        {
            public Box(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
            {
                this.UpperLeft = upperLeft;
                this.UpperRight = upperRight;
                this.BottomLeft = bottomLeft;
                this.BottomRight = bottomRight;
            }

            public Point UpperLeft { get; set; }

            public Point UpperRight { get; set; }

            public Point BottomLeft { get; set; }

            public Point BottomRight { get; set; }

            public double Width => Point.CalcDistance(this.UpperLeft, this.UpperRight);

            public double Height => Point.CalcDistance(this.UpperLeft, this.BottomLeft);

            public double Perimeter => (this.Width * 2) + (this.Height * 2);

            public double Area => this.Width * this.Height;
        }
    }
}