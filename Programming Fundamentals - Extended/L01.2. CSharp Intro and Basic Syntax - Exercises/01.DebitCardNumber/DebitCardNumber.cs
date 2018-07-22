using System;

class DebitCardNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(
            $"{firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourthNumber:d4}");
    }
}