namespace P4.MergeFiles
{
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        public static void Main()
        {
            var firstFileLines = File.ReadAllLines("FileOne.txt");
            var secondFileLines = File.ReadAllLines("FileTwo.txt");

            var mergedLines = firstFileLines
                .Concat(secondFileLines)
                .Select(int.Parse)
                .OrderBy(n => n)
                .Select(n => n.ToString())
                .ToArray();

            File.WriteAllLines("FileThree.txt", mergedLines);
        }
    }
}