namespace P05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {
            var inputNotes = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var allNaturNotesFreqs = new List<double> { 261.63, 293.66, 329.63, 349.23, 392.00, 440.00, 493.88 };
            var naturalNotesFrequencies = new List<double>();

            var naturalNotesSigns = new List<string>();
            var allNaturNotesSigns = new List<string> { "C", "D", "E", "F", "G", "A", "B" };

            var allInputNotesSigns = new List<string>();

            var sharpNotesFrequencies = new List<double>();
            var allSharpNotesFreqs = new List<double> { 277.18, 311.13, 369.99, 415.30, 466.16 };

            var sharplNotesSigns = new List<string>();
            var allSharplNotesSigns = new List<string> { "C#", "D#", "F#", "G#", "A#" };

            foreach (var note in inputNotes)
            {
                var index = 0;

                if (allNaturNotesFreqs.Contains(note))
                {
                    naturalNotesFrequencies.Add(note);

                    index = allNaturNotesFreqs.IndexOf(note);

                    naturalNotesSigns.Add(allNaturNotesSigns[index]);

                    allInputNotesSigns.Add(allNaturNotesSigns[index]);
                }
                else
                {
                    sharpNotesFrequencies.Add(note);

                    index = allSharpNotesFreqs.IndexOf(note);

                    sharplNotesSigns.Add(allSharplNotesSigns[index]);

                    allInputNotesSigns.Add(allSharplNotesSigns[index]);
                }
            }

            var sumNaturalNotesFrequencies = naturalNotesFrequencies.Sum();
            var sumSharpNotesFrequencies = sharpNotesFrequencies.Sum();

            Console.WriteLine($"Notes: {string.Join(" ", allInputNotesSigns)}");

            Console.WriteLine($"Naturals: {string.Join(", ", naturalNotesSigns)}");

            Console.WriteLine($"Sharps: {string.Join(", ", sharplNotesSigns)}");

            Console.WriteLine($"Naturals sum: {sumNaturalNotesFrequencies:0.##}");

            Console.WriteLine($"Sharps sum: {sumSharpNotesFrequencies:0.##}");
        }
    }
}