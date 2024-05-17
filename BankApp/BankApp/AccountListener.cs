using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.AccountMgmt;

namespace BankApp.AccountMgmt.Receivers
{
    public class AccountListener
    {
        public AccountListener() 
        {

        }

        public void AactivateAccount(object? sender, EventArgs e)
        {
            Console.WriteLine("Your account has been activated. Enjoy Banking with us");
        }
        
        public void DeactivateAccount(object? sender, EventArgs e)
        {
            Console.WriteLine("Your account has been deactivated due to insufficient funds");
        }        

        public void SendEmail(object? sender, EventArgs e)
        {
            Console.WriteLine("Email has been sent to your registered Email Id");
        }

        public void SendSMS(object? sender, EventArgs e)
        {
            Console.WriteLine("SMS has been sent to your registered contact Number");

        }
    }
}
