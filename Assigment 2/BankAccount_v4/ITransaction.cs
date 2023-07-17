using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_v4
{
    public interface ITransaction
    {
        void ExecuteTransaction(double amount);
        void PrintTransaction(double amount);
    }
}
