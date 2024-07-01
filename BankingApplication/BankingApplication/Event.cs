using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{

    public delegate void Operation();
    public class Eventhandler
    {
        public static void BlockAccount()
        {
            Console.WriteLine("Your Account is blocked temporary");
        }

        public static void PayIncomeTax()
        {
            Console.WriteLine("20% deducted from your account");
        }

        public static void SendEmail()
        {
            Console.WriteLine("Your details is send to your email");
        }

        public static void SendSMS() {
            Console.WriteLine("Your details is send to your SMS");


        }
    }
    
}
