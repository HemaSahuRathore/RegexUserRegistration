using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class UserRegistration
    {
        //Method to validate Name
        public static void ValidateName(string name)
        {
            if (Regex.IsMatch(name, UserRegistrationPattern.namePattern))
                Console.WriteLine("{0} is valid", name);            
            else
                Console.WriteLine("Please enter valid name");       
        }

        //Validate Email Address 
        public static void ValidateEmail(string emailID)
        {
            if (Regex.IsMatch(emailID, UserRegistrationPattern.emailPattern))
                Console.WriteLine("{0} is Valid", emailID);
            else
                Console.WriteLine("Please enter valid email ID", emailID);
        }

    }
}
