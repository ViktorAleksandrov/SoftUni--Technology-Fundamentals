namespace P03.Trainegram
{
    using System;
    using System.Text.RegularExpressions;

    public class Trainegram
    {
        public static void Main()
        {
            var trainRegex = new Regex(
                @"^<\[[^a-zA-Z\d]*]\.(.\[[a-zA-Z\d]*]\.)*$");

            var input = Console.ReadLine();

            while (input != "Traincode!")
            {
                if (trainRegex.IsMatch(input))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}