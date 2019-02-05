using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace program6
{
    class Email
    {
       public Boolean email_isValid(string em)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(em, pattern))
            {
                Console.WriteLine("True");
                return true;

            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

    }

    class IpAddress
    {
        public Boolean ip_isValid(string ip)
        {
            string pattern1 = null;
            pattern1 = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.
    ([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

            if (Regex.IsMatch(ip, pattern1))
            {
                Console.WriteLine("True");
                return true;

            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }

    class UserValidation
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Enter the email to be verified:");
                string emailStr = Console.ReadLine();
                Email e=new Email();
                e.email_isValid(emailStr);

                Console.WriteLine("Enter the IP to be verified:");
                string ipAddress = Console.ReadLine();
                IpAddress i=new IpAddress();
                i.ip_isValid(ipAddress);

        }
        }
}
