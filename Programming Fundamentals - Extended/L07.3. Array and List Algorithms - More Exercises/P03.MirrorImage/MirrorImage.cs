namespace P03.MirrorImage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MirrorImage
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var command = Console.ReadLine();

            while (command != "Print")
            {
                var specialIndex = int.Parse(command);

                var leftPart = new List<string>();
                var rightPart = new List<string>();

                for (var index = 0; index < input.Count; index++)
                {
                    var currentElement = input[index];

                    if (index < specialIndex)
                    {
                        leftPart.Add(currentElement);
                    }
                    else if (index == specialIndex)
                    {
                        leftPart.Reverse();
                        leftPart.Add(currentElement);
                    }
                    else
                    {
                        rightPart.Add(currentElement);
                    }
                }

                rightPart.Reverse();

                input = leftPart.Concat(rightPart).ToList();

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}