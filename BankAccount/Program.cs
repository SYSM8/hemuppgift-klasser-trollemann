using System.Security.Principal;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("123456789", "John Doe", 1000);

            bankAccount.Deposit(500);
            bankAccount.Withdraw(200);
            bankAccount.DisplayBalance();
        }
    }
}
