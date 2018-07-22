namespace P08.StringEncryption
{
    using System;

    public class StringEncryption
    {
        public static void Main()
        {
            var charCount = int.Parse(Console.ReadLine());

            var resultString = string.Empty;

            for (var i = 0; i < charCount; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());

                resultString += Encrypt(currentChar);
            }

            Console.WriteLine(resultString);
        }

        private static string Encrypt(char currentChar)
        {
            var asciiCode = (int)currentChar;

            var firstDigit = 0;

            if (asciiCode >= 100)
            {
                firstDigit = asciiCode / 100;
            }
            else
            {
                firstDigit = asciiCode / 10;
            }

            var secondDigit = asciiCode % 10;

            var firstPartString = (char)(asciiCode + secondDigit);

            var middlePartString = firstDigit.ToString() + secondDigit;

            var lastPartString = (char)(asciiCode - firstDigit);

            var currentString = string.Empty + firstPartString + middlePartString + lastPartString;

            return currentString;
        }
    }
}