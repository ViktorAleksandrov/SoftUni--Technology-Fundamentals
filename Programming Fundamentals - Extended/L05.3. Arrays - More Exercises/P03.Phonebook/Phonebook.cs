namespace P03.Phonebook
{
    using System;

    public class Phonebook
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var names = Console.ReadLine().Split();

            var inputName = Console.ReadLine();

            while (inputName != "done")
            {
                var index = Array.IndexOf(names, inputName);

                var currentName = names[index];
                var currentPhoneNumber = phoneNumbers[index];

                Console.WriteLine(
                    $"{currentName} -> {currentPhoneNumber}");

                inputName = Console.ReadLine();
            }
        }
    }
}