using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_v4
{
    public class Transaction : ITransaction
    {
        private int TransID { get; set; }
        private int TransAmount { get; set; }
        private int Acc_Num { get; set; }
        public List<Transaction> TransactionList;
        public Transaction(int acc_num, double amount)
        {
            TransAmount = (int)amount;
            TransID = acc_num * 2;
            Acc_Num = acc_num;
            TransactionList = new List<Transaction>();
        }
        public void AddTransaction(Transaction transaction)
        {
            TransactionList.Add(transaction);
            Console.WriteLine($"Transaction: {transaction.TransID} has ben added in the transaction list");
            TransID++;
        }
        public void ExecuteTransaction(double amount)
        {
            Console.WriteLine($"Transaction has been executed for account number{Acc_Num}");
        }
        public void PrintTransaction(double amount)
        {
            Console.WriteLine($"Transaction of {amount} has been executed for account number{Acc_Num}");
        }
        public void ViewTransaction(int acc_num)
        {
            bool state = false;
            foreach (Transaction transaction in TransactionList)
            {
                if(transaction.Acc_Num== acc_num)
                {
                    Console.WriteLine(TransID);
                    state = true;
                }
            }
            if(state == false)
            {
                Console.WriteLine("transaction not found for this account");
            }
        }
    }
}
