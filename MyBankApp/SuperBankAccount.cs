using System;
using System.Text;
using System.Collections.Generic;




namespace MyBankApp
{
    public class SuperBankAccount
    {
        // using ? to handle nullable error
        public string? Number { get; }
        public string? Owner { get; set; }

        public decimal? Balance
        {
            get
            {
                decimal balance = 0;

                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }


        }

        // Initialize account number with 10 digit number and increment every time.

        private int accountNumber = 1234567890;

        private List<Transactions> allTransactions = new List<Transactions>();

        public SuperBankAccount(string name, decimal InitialBalance)
        {
            this.Owner = name;
            // Making a transactions
            MakeDeposit(InitialBalance, DateTime.Now, "Seed Fund");
            this.Number = accountNumber.ToString();
            accountNumber++;
        }

        // Functions
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transactions(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}