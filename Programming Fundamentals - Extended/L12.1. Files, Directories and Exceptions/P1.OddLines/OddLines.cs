namespace P1.OddLines
{
    using System.IO;
    using System.Linq;

    public class OddLines
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("lines.txt");

            var oddLines = lines
                .Where((line, index) => index % 2 == 1);

            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}