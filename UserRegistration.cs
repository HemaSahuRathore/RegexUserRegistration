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
    }
}
