namespace P15.CountOfCapitalLettersInArray
{
    using System;

    public class CountOfCapitalLettersInArray
    {
        private static void Main()
        {
            var words = Console.ReadLine().Split();

            var capitalLettersCounter = 0;

            foreach (var word in words)
            {
                var letter = word[0];

                if (word.Length == 1 && char.IsUpper(letter))
                {
                    capitalLettersCounter++;
                }
            }

            Console.WriteLine(capitalLettersCounter);
        }
    }
}