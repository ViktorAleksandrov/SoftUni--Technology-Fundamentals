namespace P5.FolderSize
{
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");

            var size = files
                .Select(file => new FileInfo(file))
                .Select(file => file.Length)
                .Sum();

            var sizeInMb = size / 1024.0 / 1024;

            File.WriteAllText("Output.txt", sizeInMb.ToString());
        }
    }
}