namespace P16.ArraySymmetry
{
    using System;

    public class ArraySymmetry
    {
        private static void Main()
        {
            var arr = Console.ReadLine().Split();

            var length = arr.Length;

            for (var index = 0; index < length / 2; index++)
            {
                var frontEndElemnt = arr[index];
                var backEndElement = arr[length - 1 - index];

                if (frontEndElemnt != backEndElement)
                {
                    Console.WriteLine("No");

                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}