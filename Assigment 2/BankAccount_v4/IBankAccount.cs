using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_v4
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
