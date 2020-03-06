using System;
using System.Collections.Generic;
using task_3.Classes;
using task_3.Enums;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new List<BankAccount>
            {
                new BankAccount("00001", 100.65, AccountType.Checking),
                new BankAccount("00002", 74.00, AccountType.Checking),
                new BankAccount("00003", 355.50, AccountType.Giro),
                new BankAccount("00004", 60.35, AccountType.Savings),
                new BankAccount("00005", 125.00, AccountType.Giro)
            };

            var selected = 0;

            do
            {
                PrintMenu();

                var isSelectionValid = Int32.TryParse(Console.ReadLine(), out selected);

                if (!isSelectionValid || (selected != 0 && selected != 1 && selected != 2))
                {
                    selected = -1;
                    Console.WriteLine(" Invalid choice!");
                    PrintLineBreak();
                    continue;
                }

                switch(selected)
                {
                    case 1:
                        AddBankAccount(bankAccounts);
                        continue;
                    case 2:
                        PrintBankAccounts(bankAccounts);
                        continue;
                    default:
                        continue;
                }

            } while (selected != 0);
        }

        static void PrintMenu()
        {
            PrintLineBreak();
            Console.WriteLine("| Choose one of the following   |");
            PrintLineBreak("|");
            Console.WriteLine();
            Console.WriteLine("| 1) Add new Account            |");
            Console.WriteLine("| 2) View all Accounts          |");
            PrintLineBreak();
            Console.WriteLine();
            Console.WriteLine("| 0) Exit                       |");
            PrintLineBreak();
        }

        static void PrintBankAccounts(List<BankAccount> bankAccounts)
        {
            PrintLineBreak();
            Console.WriteLine("| All bank accounts             |");
            PrintLineBreak("|");

            foreach (var bankAccount in bankAccounts)
            {
                Console.WriteLine();
                Console.WriteLine(bankAccount);
                PrintLineBreak();
            }
            Console.WriteLine();
        }

        static void AddBankAccount(List<BankAccount> bankAccounts)
        {
            Console.WriteLine("| Insert account number:        |");
            var accountNumber = Console.ReadLine();

            Console.WriteLine("| Insert balance:               |");
            var isBalanceOfTypeLong = double.TryParse(Console.ReadLine(), out var balance);

            if (!isBalanceOfTypeLong)
            {
                Console.WriteLine("| Balance must be of type double! |");
                return;
            }

            Console.WriteLine("| Choose account type:          |");
            PrintLineBreak("|");
            Console.WriteLine();
            Console.WriteLine("| 0) Savings Account            |");
            Console.WriteLine("| 1) Checking Account           |");
            Console.WriteLine("| 2) Giro Account               |");
            PrintLineBreak();

            var isAccountTypeValid = Int32.TryParse(Console.ReadLine(), out var accountTypeNumber);

            if (!isAccountTypeValid || (accountTypeNumber != 0 && accountTypeNumber != 1 && accountTypeNumber != 2))
            {
                Console.WriteLine(" Invalid choice!");
                PrintLineBreak();
                return;
            }

            var accountToAdd = new BankAccount(accountNumber, balance, (AccountType)accountTypeNumber);

            bankAccounts.Add(accountToAdd);

            Console.WriteLine($"Account number: {accountToAdd.AccountNumber} has been successfully added!");
        }

        static void PrintLineBreak(string margin = " ")
        {
            Console.WriteLine($"{margin}_______________________________{margin}");
        }
    }
}
