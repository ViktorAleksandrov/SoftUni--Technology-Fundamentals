namespace P04.FloatOrInteger
{
    using System;

    public class FloatOrInteger
    {
        public static void Main()
        {
            var inputNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(inputNumber));
        }
    }
}