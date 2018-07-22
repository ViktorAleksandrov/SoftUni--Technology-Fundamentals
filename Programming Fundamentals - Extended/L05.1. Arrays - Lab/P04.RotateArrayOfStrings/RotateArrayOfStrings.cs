namespace P04.RotateArrayOfStrings
{
    using System;

    public class RotateArrayOfStrings
    {
        private static void Main()
        {
            var inputArr = Console.ReadLine().Split();

            var rotatedArr = new string[inputArr.Length];

            for (var index = 0; index < inputArr.Length; index++)
            {
                var rotIndex = (index + 1) % rotatedArr.Length;

                rotatedArr[rotIndex] = inputArr[index];
            }

            Console.WriteLine(string.Join(" ", rotatedArr));
        }
    }
}