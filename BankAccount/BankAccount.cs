using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance = amount + Balance;
            Console.WriteLine($"deposited: {amount}, new balance: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;

            if (amount > Balance)
            {
                Console.WriteLine("you don't have the sufficient amount in your account");
            }
            else
            {
                Console.WriteLine($"withdrew: {amount}, new balance: {Balance}");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"balance: {Balance}");
        }
    }
}
