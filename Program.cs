using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{

    class PinCode
    {
        public bool CheckPinCode(string pin)
        {
            //Use Case 1
            string pattern = @"[1-9][0-9]{2}\s{0,1}[0-9]{3}$";
            return Regex.IsMatch(pin, pattern);
        }
    }

    class Email
    {
        public bool CheckEmail(string mail)
        {
            //Use Case 1
            string pattern = @"^[a-zA-Z0-9]+@[a-z]+\.[a-z]{2,4}$";
            return Regex.IsMatch(mail, pattern); 
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Practice Problem");
            Console.Write("Enter Pin Code: ");
            PinCode pinMatch = new PinCode();

            if (pinMatch.CheckPinCode(Console.ReadLine()))
                Console.WriteLine("Pin Code is Valid");
            else
                Console.WriteLine("Pin Code is Invalid");

            Console.Write("Enter Email Address: ");
            Email mailMatch = new Email();
            if (mailMatch.CheckEmail(Console.ReadLine()))
                Console.WriteLine("Mail is Valid");
            else
                Console.WriteLine("Mail is Invalid");

            //Temp Read Line to view Console
            Console.ReadLine();
        }
    }
}
