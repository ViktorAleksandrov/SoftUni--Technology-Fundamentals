using System;

class RectangleArea
{
    static void Main()
    {
        double rectangleWidth = double.Parse(Console.ReadLine());
        double rectangleHeight = double.Parse(Console.ReadLine());

        double rectangleArea = rectangleWidth * rectangleHeight;

        Console.WriteLine($"{rectangleArea:f2}");
    }
}