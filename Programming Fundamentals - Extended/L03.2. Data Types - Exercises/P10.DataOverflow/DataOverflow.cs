namespace P10.DataOverflow
{
    using System;

    public class DataOverflow
    {
        public static void Main()
        {
            var firstNumber = ulong.Parse(Console.ReadLine());
            var secondNumber = ulong.Parse(Console.ReadLine());

            var smallerNumber = Math.Min(firstNumber, secondNumber);
            var typeSmallerNumber = GetType(smallerNumber);

            var biggerNumber = Math.Max(firstNumber, secondNumber);
            var typeBiggerNumber = GetType(biggerNumber);

            var typeMaxValue = 0m;

            switch (typeSmallerNumber)
            {
                case "byte":
                    typeMaxValue = byte.MaxValue;
                    break;
                case "ushort":
                    typeMaxValue = ushort.MaxValue;
                    break;
                case "uint":
                    typeMaxValue = uint.MaxValue;
                    break;
                case "ulong":
                    typeMaxValue = ulong.MaxValue;
                    break;
            }

            var overflowCount = biggerNumber / typeMaxValue;

            Console.WriteLine(
                $"bigger type: {typeBiggerNumber}\n"
                + $"smaller type: {typeSmallerNumber}");

            Console.WriteLine(
                $"{biggerNumber} can overflow {typeSmallerNumber} {overflowCount:f0} times");
        }

        private static string GetType(ulong number)
        {
            var type = string.Empty;

            if (number > uint.MaxValue)
            {
                type = "ulong";
            }
            else if (number > ushort.MaxValue)
            {
                type = "uint";
            }
            else if (number > byte.MaxValue)
            {
                type = "ushort";
            }
            else
            {
                type = "byte";
            }

            return type;
        }
    }
}