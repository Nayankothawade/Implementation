using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.AccountMgmt;
using BankApp.AccountMgmt.Receivers;

namespace BankApp.Banks.SBI
{
    public class SBIBank
    {
        public SBIBank()
        {

        }

        public void PerformBankingOperation(Account acct, AccountListener listener)
        {
            acct.deactivate += listener.DeactivateAccount;
            acct.deactivate += listener.SendEmail;
            acct.deactivate += listener.SendSMS;

            Console.WriteLine(acct.Balance);
            acct.Withdraw(6000);
            Console.WriteLine(acct.Balance);
        }
    }
}