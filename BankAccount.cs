using System;

namespace CSharpBankAccountSystem
{
    public class BankAccount
    {
        private double balance;

        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }

        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposit successful!");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful!");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {balance:F2}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("\n===== ACCOUNT INFORMATION =====");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}
