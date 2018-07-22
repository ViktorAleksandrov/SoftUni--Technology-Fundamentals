namespace P01.ValueOfAString
{
    using System;
    using System.Linq;

    public class ValueOfAString
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var letterCase = Console.ReadLine();

            var sum = 0;

            switch (letterCase)
            {
                case "LOWERCASE":
                    sum = inputText
                        .Where(char.IsLower)
                        .Sum(ch => ch);
                    break;
                case "UPPERCASE":
                    sum = inputText
                        .Where(char.IsUpper)
                        .Sum(ch => ch);
                    break;
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}