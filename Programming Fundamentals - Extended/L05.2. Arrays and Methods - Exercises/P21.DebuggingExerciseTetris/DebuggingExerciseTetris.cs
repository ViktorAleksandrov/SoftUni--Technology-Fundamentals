namespace P21.DebuggingExerciseTetris
{
    using System;

    public class DebuggingExerciseTetris
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        TurnFaceUp(n);
                        break;
                    case "right":
                        TurnFaceRight(n);
                        break;
                    case "down":
                        TurnFaceDown(n);
                        break;
                    case "left":
                        TurnFaceLeft(n);
                        break;
                }

                currentDirection = Console.ReadLine();
            }
        }

        private static void TurnFaceLeft(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n) + new string('*', n));
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n) + new string('*', n));
            }
        }

        private static void TurnFaceRight(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n) + new string('.', n));
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n) + new string('.', n));
            }
        }

        private static void TurnFaceUp(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(
                    "{0}{1}{0}", new string('.', n), new string('*', n));
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }
        }

        private static void TurnFaceDown(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(
                    "{0}{1}{0}", new string('.', n), new string('*', n));
            }
        }
    }
}