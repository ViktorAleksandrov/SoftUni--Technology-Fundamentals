using System;

class Megapixels
{
    static void Main()
    {
        int widthOfImage = int.Parse(Console.ReadLine());
        int heightOfImage = int.Parse(Console.ReadLine());

        double megapixels = (widthOfImage * heightOfImage) / 1000000.0;

        Console.WriteLine(
            $"{widthOfImage}x{heightOfImage} => {Math.Round(megapixels, 1)}MP");
    }
}