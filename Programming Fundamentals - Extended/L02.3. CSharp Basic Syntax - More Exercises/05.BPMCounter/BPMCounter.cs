using System;

class BPMCounter
{
    static void Main()
    {
        int beatsPerMinute = int.Parse(Console.ReadLine());
        int numberOfBeats = int.Parse(Console.ReadLine());

        double bars = Math.Round(numberOfBeats / 4.0, 1);

        double totalTimeInSeconds = (60.0 / beatsPerMinute) * numberOfBeats;

        int minutes = (int)totalTimeInSeconds / 60;
        int seconds = (int)totalTimeInSeconds % 60;

        Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
    }
}