namespace P16.TrickyStrings
{
    using System;
    using System.Text;

    public class TrickyStrings
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();

            var linesNumber = int.Parse(Console.ReadLine());

            var concatenatedStrings = new StringBuilder();

            for (var index = 0; index < linesNumber; index++)
            {
                concatenatedStrings.Append(Console.ReadLine() + delimiter);

                if (index < linesNumber - 1)
                {
                    concatenatedStrings.Append(delimiter);
                }
            }

            Console.WriteLine(concatenatedStrings);
        }
    }
}