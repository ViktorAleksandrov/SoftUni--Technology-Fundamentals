namespace P14.ASCIIString
{
    using System;
    using System.Text;

    public class AsciiString
    {
        public static void Main()
        {
            var linesNumber = int.Parse(Console.ReadLine());

            var word = new StringBuilder();

            for (var index = 0; index < linesNumber; index++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                word.Append((char)currentNumber);
            }

            Console.WriteLine(word);
        }
    }
}