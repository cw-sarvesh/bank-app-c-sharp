﻿using System;

namespace MyBankApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Read owner and initial balance from user

            Console.WriteLine("Please input user name to open account.");

            string? Owner = Console.ReadLine();

            // If ownner is null default value witll be User.
            Owner = null ?? "User";
            Console.WriteLine("Please input initial balance to open account.");

            // Getting input and converting to decimal.

            string? number = Console.ReadLine();

            number = null ?? "0";

            decimal InitialBalance = Convert.ToDecimal(number);

            // Passing parameter to another class.
            var account = new SuperBankAccount(Owner, InitialBalance);

            // Printing details of account.
            Console.WriteLine($"Account is created for {account.Owner} with {account.Balance} as initial balance. Welcome in SuperBank!");
        }
    }
}