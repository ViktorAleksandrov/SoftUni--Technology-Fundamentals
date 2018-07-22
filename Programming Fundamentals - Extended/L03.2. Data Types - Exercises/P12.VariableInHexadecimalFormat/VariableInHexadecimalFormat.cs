namespace P12.VariableInHexadecimalFormat
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            var hexNumber = Console.ReadLine();

            var decimalNumber = Convert.ToInt32(hexNumber, 16);

            Console.WriteLine(decimalNumber);
        }
    }
}