namespace P06.RectanglePosition
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            Console.WriteLine(
                firstRectangle.IsInside(secondRectangle) ? "Inside" : "Not inside");
        }

        public static Rectangle ReadRectangle()
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var rectangle = new Rectangle()
            {
                Left = size.First(),
                Top = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Height = size.Last()
            };

            return rectangle;
        }

        public class Rectangle
        {
            public int Top { get; set; }

            public int Left { get; set; }

            public int Width { get; set; }

            public int Height { get; set; }

            public int Right => this.Left + this.Width;

            public int Bottom => this.Top + this.Height;

            public bool IsInside(Rectangle other)
            {
                var isInLeft = this.Left >= other.Left;
                var isInRight = this.Right <= other.Right;

                var isInsideHorizontal = isInLeft && isInRight;

                var isInTop = this.Top >= other.Top;
                var isInBottom = this.Bottom <= other.Bottom;

                var isInsideVertical = isInTop && isInBottom;

                return isInsideHorizontal && isInsideVertical;
            }
        }
    }
}