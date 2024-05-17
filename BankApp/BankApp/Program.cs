using System.Security.Principal;
using BankApp.AccountMgmt;
using BankApp.AccountMgmt.Receivers;
using BankApp.Banks.HDFC;
using BankApp.Banks.SBI;

Console.WriteLine("Welcome to NK Banking_Solutions..!");

Account acct = new Account(35000);

AccountListener listener = new AccountListener();

HDFCBank hDFCBank = new HDFCBank();
hDFCBank.PerformBankingOperation(acct, listener);

SBIBank sBIBank = new SBIBank();
sBIBank.PerformBankingOperation(acct, listener);

Console.ReadLine();