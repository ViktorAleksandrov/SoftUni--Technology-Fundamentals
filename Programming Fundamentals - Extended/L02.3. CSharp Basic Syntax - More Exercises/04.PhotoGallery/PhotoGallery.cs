using System;

class PhotoGallery
{
    static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double size = double.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        string megaBytes = string.Empty;

        if (size < 1000)
        {
            megaBytes = "B";
        }
        else if (size < 1000000)
        {
            size /= 1000;
            megaBytes = "KB";
        }
        else
        {
            size /= 1000000;
            megaBytes = "MB";
        }

        string orientation = string.Empty;

        if (width > height)
        {
            orientation = "landscape";
        }
        else if (height > width)
        {
            orientation = "portrait";
        }
        else
        {
            orientation = "square";
        }

        Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
        Console.WriteLine($"Size: {size}{megaBytes}");
        Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
    }
}