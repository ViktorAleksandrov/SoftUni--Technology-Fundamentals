namespace P03.MixedPhones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var phonebook = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                if (long.TryParse(input[0], out var number))
                {
                    phonebook[input[2]] = number;
                }
                else
                {
                    phonebook[input[0]] = long.Parse(input[2]);
                }

                input = Console.ReadLine().Split();
            }

            foreach (var name in phonebook.Keys)
            {
                var phoneNumber = phonebook[name];

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}