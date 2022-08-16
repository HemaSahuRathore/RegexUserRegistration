namespace RegexUserRegistration
{    /// <summary>
     /// UC 8 : As a User need to follow pre-defined Password rules.
     /// Rule 4 – Should have exactly one special character 
     /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.Write("\nEnter your First Name : ");
            string firstName = Console.ReadLine();
            UserRegistration.ValidateName(firstName);

            Console.Write("\nEnter your Last Name : ");
            string lastName = Console.ReadLine();
            UserRegistration.ValidateName(lastName);

            Console.Write("\nEnter Email Address : ");
            string emailId = Console.ReadLine();
            UserRegistration.ValidateEmail(emailId);

            Console.Write("\nEnter Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            UserRegistration.ValidateMobile(mobileNumber);

            Console.Write("\nEnter Password : ");
            string pswd = Console.ReadLine();
            UserRegistration.ValidatePaswd(pswd);
            Console.WriteLine();

            Console.WriteLine("\n Valid Cases : ");
            string[] validInput = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            UserRegistration.ValidateEmail(validInput);
            Console.WriteLine("\n Invalid Cases: ");
            string[] invalidInput = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "bc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            UserRegistration.ValidateEmail(invalidInput);

        }
    }
}