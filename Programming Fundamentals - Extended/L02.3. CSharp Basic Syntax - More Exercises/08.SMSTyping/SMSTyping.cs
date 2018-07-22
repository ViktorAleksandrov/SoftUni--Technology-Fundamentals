using System;

class SMSTyping
{
    static void Main()
    {
        int numberOfChars = int.Parse(Console.ReadLine());

        string sms = string.Empty;

        for (int currentChar = 0; currentChar < numberOfChars; currentChar++)
        {
            string digitsToConvert = Console.ReadLine();

            int mainDigit = int.Parse(digitsToConvert[0].ToString());

            if (mainDigit == 0)
            {
                sms += " ";
            }
            else
            {
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + digitsToConvert.Length) - 1;

                sms += (char)(letterIndex + 'a');
            }
        }

        Console.WriteLine(sms);
    }
}