namespace P07.ResizableArray
{
    using System;

    public class ResizableArray
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var command = input[0];

            var elementsCount = 0;

            var numbers = new int[4];

            while (command != "end")
            {
                switch (command)
                {
                    case "push":
                        if (elementsCount == numbers.Length)
                        {
                            var tempNumbers = new int[elementsCount * 2];

                            for (var i = 0; i < elementsCount; i++)
                            {
                                tempNumbers[i] = numbers[i];
                            }

                            numbers = tempNumbers;
                        }

                        for (var i = elementsCount; i <= elementsCount; i++)
                        {
                            numbers[i] = int.Parse(input[1]);
                        }

                        elementsCount++;
                        break;

                    case "pop":
                        elementsCount--;
                        break;

                    case "removeAt":
                        var index = int.Parse(input[1]);

                        for (var i = index; i < elementsCount - 1; i++)
                        {
                            numbers[i] = numbers[i + 1];
                        }

                        elementsCount--;
                        break;

                    case "clear":
                        elementsCount = 0;
                        break;
                }

                input = Console.ReadLine().Split();

                command = input[0];
            }

            if (elementsCount == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                for (var i = 0; i < elementsCount; i++)
                {
                    var currentNumber = numbers[i];

                    Console.Write(currentNumber + " ");
                }

                Console.WriteLine();
            }
        }
    }
}