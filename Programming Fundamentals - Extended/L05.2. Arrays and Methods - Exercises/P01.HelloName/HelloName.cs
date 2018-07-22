namespace P01.HelloName
{
    using System;

    public class HelloName
    {
        private static void Main()
        {
            PrintHelloName(Console.ReadLine());
        }

        private static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}