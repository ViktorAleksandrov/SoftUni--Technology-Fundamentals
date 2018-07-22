namespace P07.FromTerabytesToBits
{
    using System;

    public class FromTerabytesToBits
    {
        public static void Main()
        {
            var terabytes = double.Parse(Console.ReadLine());

            var oneTerabyte = 8 * Math.Pow(1024, 4);

            var bits = terabytes * oneTerabyte;

            Console.WriteLine(bits);
        }
    }
}