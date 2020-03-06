using System;
using task_3.Enums;

namespace task_3.Classes
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public AccountType Type { get; set; }

        public BankAccount()
        {
            
        }
        
        public BankAccount(string accountNumber, double balance, AccountType type)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Type = type;
        }

        public override string ToString()
        {
            return $"Account number: {AccountNumber}\n" +
                $"Balance: {Balance.ToString("C")}\n" +
                $"Type: {Type}";
        }
    }
}
