namespace P06.OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { " -> " }, StringSplitOptions.None);

            var banksData = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputLine[0] != "end")
            {
                var bank = inputLine[0];
                var account = inputLine[1];
                var balance = decimal.Parse(inputLine[2]);

                if (!banksData.ContainsKey(bank))
                {
                    banksData[bank] = new Dictionary<string, decimal>();
                }

                if (!banksData[bank].ContainsKey(account))
                {
                    banksData[bank][account] = 0;
                }

                banksData[bank][account] += balance;

                inputLine = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.None);
            }

            var orderedBanksData = banksData
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ThenByDescending(kvp => kvp.Value.Values.Max());

            foreach (var pair in orderedBanksData)
            {
                var accountsData = pair.Value.OrderByDescending(kvp => kvp.Value);

                foreach (var accountBalance in accountsData)
                {
                    var account = accountBalance.Key;
                    var balance = accountBalance.Value;
                    var bank = pair.Key;

                    Console.WriteLine($"{account} -> {balance} ({bank})");
                }
            }
        }
    }
}