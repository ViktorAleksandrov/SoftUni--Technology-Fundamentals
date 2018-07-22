namespace P17.CypherRoulette
{
    using System;

    public class CypherRoulette
    {
        public static void Main()
        {
            var linesNumber = int.Parse(Console.ReadLine());

            var isSpinLeft = false;

            var cypherString = string.Empty;

            var previousString = string.Empty;

            for (var index = 0; index < linesNumber; index++)
            {
                var currentString = Console.ReadLine();

                if (currentString == previousString)
                {
                    cypherString = string.Empty;

                    if (currentString == "spin")
                    {
                        index--;
                    }
                }
                else if (currentString == "spin")
                {
                    isSpinLeft = !isSpinLeft;

                    index--;
                }
                else if (isSpinLeft)
                {
                    cypherString = currentString + cypherString;
                }
                else
                {
                    cypherString += currentString;
                }

                previousString = currentString;
            }

            Console.WriteLine(cypherString);
        }
    }
}