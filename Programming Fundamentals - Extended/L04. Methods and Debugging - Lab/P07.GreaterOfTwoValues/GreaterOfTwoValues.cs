namespace P07.GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        var first = int.Parse(Console.ReadLine());
                        var second = int.Parse(Console.ReadLine());

                        var max = GetMax(first, second);

                        Console.WriteLine(max);
                    }

                    break;

                case "char":
                    {
                        var first = char.Parse(Console.ReadLine());
                        var second = char.Parse(Console.ReadLine());

                        var max = GetMax(first, second);

                        Console.WriteLine(max);
                    }

                    break;

                case "string":
                    {
                        var first = Console.ReadLine();
                        var second = Console.ReadLine();

                        var max = GetMax(first, second);

                        Console.WriteLine(max);
                    }

                    break;
            }
        }

        private static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        private static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        private static string GetMax(string first, string second)
        {
            return first.CompareTo(second) > 0 ? first : second;
        }
    }
}