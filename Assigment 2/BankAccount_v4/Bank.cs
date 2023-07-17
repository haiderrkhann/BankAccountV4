using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_v4
{
    public class Bank
    {
        public List<BankAccount> BankAccounts;
        Dictionary<int, BankAccount> MyDictionary;

        public Bank()
        {
            BankAccounts = new List<BankAccount>();
            MyDictionary = new Dictionary<int, BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            BankAccounts.Add(account);
            Console.WriteLine($"{account.AccountHolderName}'s account ({account.AccountNumber}) has been added!");
        }
        public void DepositToAccount(int accountNumber, double amount)
        {
            bool accountFound = false;

            for (int i = 0; i < BankAccounts.Count; i++)
            {
                if (BankAccounts[i].AccountNumber == accountNumber)
                {
                    BankAccounts[i].Deposit(amount);
                    accountFound = true;
                    break;
                }
            }

            if (!accountFound)
            {
                Console.WriteLine("Account not found.");
            }
        }
        public void WithdrawFromAccount(int accountNumber, double amount)
        {
            bool accountFound = false;

            for (int i = 0; i < BankAccounts.Count; i++)
            {
                if (BankAccounts[i].AccountNumber == accountNumber)
                {
                    BankAccounts[i].Withdraw(amount);
                    accountFound = true;
                    break;
                }
            }

            if (!accountFound)
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
