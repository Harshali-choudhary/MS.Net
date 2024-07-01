
using BankingApplication;

Account acct= new Account();
acct.balance = 40000;
acct.overBalance += BankingApplication.Eventhandler.PayIncomeTax;
acct.overBalance += BankingApplication.Eventhandler.SendEmail;
acct.underBalance += BankingApplication.Eventhandler.BlockAccount;
acct.underBalance += BankingApplication.Eventhandler.SendSMS;

acct.withdraw(35000);
acct.deposit(300000);