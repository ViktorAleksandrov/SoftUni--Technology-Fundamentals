namespace P17.Altitude
{
    using System;

    public class Altitude
    {
        private static void Main()
        {
            var commands = Console.ReadLine().Split();

            var altitude = long.Parse(commands[0]);

            for (var index = 1; index < commands.Length; index += 2)
            {
                var direction = commands[index];

                var altitudeValueChange = long.Parse(commands[index + 1]);

                switch (direction)
                {
                    case "up":
                        altitude += altitudeValueChange;
                        break;

                    case "down":

                        altitude -= altitudeValueChange;

                        if (altitude <= 0)
                        {
                            Console.WriteLine("crashed");

                            return;
                        }

                        break;
                }
            }

            Console.WriteLine(
                $"got through safely. current altitude: {altitude}m");
        }
    }
}