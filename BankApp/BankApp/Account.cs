using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.AccountMgmt
{
    public class Account
    {
        public double Balance { get; set; }

        public event EventHandler<EventArgs> deactivate;

        public Account(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount)
        {
            double predictedBalance = Balance - amount;

            if (predictedBalance <= 5000)
            {
                EventArgs eventArgs = new EventArgs();
                deactivate(this, eventArgs);
            }
            this.Balance = predictedBalance;
        }

        public void Deposit(double amount)
        {
            this.Balance = Balance + amount;
        }
    }
}
