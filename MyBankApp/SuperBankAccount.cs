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

        public decimal? Balance { get; }

        public SuperBankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {


        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {

        }
    }
}