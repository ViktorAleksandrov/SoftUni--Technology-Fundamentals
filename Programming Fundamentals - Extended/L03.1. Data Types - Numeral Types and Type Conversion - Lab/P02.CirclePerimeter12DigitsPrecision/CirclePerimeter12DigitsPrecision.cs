namespace P02.CirclePerimeter12DigitsPrecision
{
    using System;

    public class CirclePerimeter12DigitsPrecision
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"{perimeter:f12}");
        }
    }
}