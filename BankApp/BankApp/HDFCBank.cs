using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.AccountMgmt;
using BankApp.AccountMgmt.Receivers;

namespace BankApp.Banks.HDFC
{
    public class HDFCBank
    {
        public HDFCBank()
        {

        }
        
        public void PerformBankingOperation(Account acct, AccountListener listener)
        {
            acct.deactivate += listener.DeactivateAccount;  //Function Attached
            acct.deactivate += listener.SendEmail;
            acct.deactivate += listener.SendSMS;

            Console.WriteLine(acct.Balance);
            acct.Withdraw(32000);
            Console.WriteLine(acct.Balance);
        }
    }
}