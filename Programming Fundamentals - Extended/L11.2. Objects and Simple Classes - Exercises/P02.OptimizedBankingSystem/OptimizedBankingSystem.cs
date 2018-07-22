namespace P02.OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var accounts = new List<BankAccount>();

            while (input != "end")
            {
                var inputLine = input
                    .Split(new[] { " | " }, StringSplitOptions.None);

                var name = inputLine[1];
                var bank = inputLine[0];
                var balance = decimal.Parse(inputLine[2]);

                accounts.Add(new BankAccount(name, bank, balance));

                input = Console.ReadLine();
            }

            var orderedAccounts = accounts
                .OrderByDescending(a => a.Balance)
                .ThenBy(a => a.Bank.Length);

            foreach (var account in orderedAccounts)
            {
                Console.WriteLine(
                    $"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        public class BankAccount
        {
            public BankAccount(string name, string bank, decimal balance)
            {
                this.Name = name;
                this.Bank = bank;
                this.Balance = balance;
            }

            public string Name { get; set; }

            public string Bank { get; set; }

            public decimal Balance { get; set; }
        }
    }
}