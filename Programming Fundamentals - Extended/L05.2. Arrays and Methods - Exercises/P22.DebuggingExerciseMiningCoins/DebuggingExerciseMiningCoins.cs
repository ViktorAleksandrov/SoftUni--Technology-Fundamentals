namespace P22.DebuggingExerciseMiningCoins
{
    using System;

    public class DebuggingExerciseMiningCoins
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var decryptedMessage = string.Empty;

            var totalValue = 0f;

            for (var i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                var digit1 = number / 100;
                var digit2 = (number % 100) / 10;
                var digit3 = number % 10;

                totalValue += (digit1 + digit2 + digit3) / (float)n;

                var asciIcode = 0;

                if (i % 2 == 1)
                {
                    asciIcode = ((digit1 * 10) + digit3) - digit2;
                }
                else
                {
                    asciIcode = ((digit1 * 10) + digit3) + digit2;
                }

                if ((asciIcode >= 65 && asciIcode <= 90)
                    || (asciIcode >= 97 && asciIcode <= 122))
                {
                    decryptedMessage += (char)asciIcode;
                }
            }

            Console.WriteLine("Message: {0}", decryptedMessage);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}