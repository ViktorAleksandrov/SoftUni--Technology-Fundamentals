namespace P2.LineNumbers
{
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("input.txt");

            var numberedLines = lines
                .Select((line, index) => $"{index + 1}. {line}");

            File.WriteAllLines("output.txt", numberedLines);
        }
    }
}