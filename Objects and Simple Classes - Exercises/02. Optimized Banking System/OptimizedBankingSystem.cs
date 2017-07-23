namespace _02.Optimized_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            List<BankAccount> bankAcounts = new List<BankAccount>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] toknes = inputLine
                    .Split(new string[] { " | " },
                    StringSplitOptions.RemoveEmptyEntries);

                string bank = toknes[0];
                string acccountName = toknes[1];
                decimal accoutBalance = decimal.Parse(toknes[2]);

                BankAccount newBankAccout = new BankAccount
                {
                    Bank = bank,
                    Name = acccountName,
                    Balance = accoutBalance
                };

                bankAcounts.Add(newBankAccout);

                inputLine = Console.ReadLine();
            }

            bankAcounts = bankAcounts
                .OrderByDescending(b => b.Balance)
                .ThenBy(b => b.Bank.Length)
                .ToList();

            foreach (var person in bankAcounts)
            {
                Console.WriteLine($"{person.Name} -> {person.Balance} ({person.Bank})");
            }
        }
    }

    public class BankAccount
    {
        public string Name  { get; set; }
        public string Bank  { get; set; }
        public decimal Balance { get; set; }
    }
}
