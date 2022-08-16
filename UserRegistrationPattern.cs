using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{   
    public class UserRegistrationPattern
    {   
        //name validation pattern
        public static string namePattern = "^[A-Z]{1}[a-z]{2,}$";

        //email validation pattern
        public static string emailPattern = "^[0-9a-z]+([._+-][0-9a-z]+)?(@[0-9a-z]+[.][a-z]{2,})(.[a-z]{2,})?$";

        //Mobile Num validation pattern
        public static string mobNumPattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";

        //Pswd pattern
        string pswdPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%&*_+])[a-zA-Z0-9!@#$%&*_+]{8,}$";  //?= : lookahead, .* : start with any character or num
    }
}
