namespace P06.Extremums
{
    using System;
    using System.Linq;

    public class Extremums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            for (var index = 0; index < numbers.Count; index++)
            {
                var currentNumber = numbers[index];

                var element = currentNumber.ToString().ToList();

                var neededNumber = currentNumber;

                for (var cnt = 0; cnt < element.Count - 1; cnt++)
                {
                    var temp = element.First();

                    element.RemoveAt(0);
                    element.Add(temp);

                    currentNumber = int.Parse(new string(element.ToArray()));

                    if (command == "Min" && currentNumber < neededNumber)
                    {
                        neededNumber = currentNumber;
                    }
                    else if (command == "Max" && currentNumber > neededNumber)
                    {
                        neededNumber = currentNumber;
                    }
                }

                numbers[index] = neededNumber;
            }

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(numbers.Sum());
        }
    }
}