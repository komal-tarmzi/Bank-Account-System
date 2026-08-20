using System;

namespace CSharpBankAccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== C# BANK ACCOUNT SYSTEM =====");

            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            BankAccount account = new BankAccount(name, accountNumber);

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Account Information");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case "2":
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withdrawalAmount);
                        break;

                    case "3":
                        account.CheckBalance();
                        break;

                    case "4":
                        account.DisplayAccountInfo();
                        break;

                    case "5":
                        Console.WriteLine("Thank you for using the Bank Account System!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
