namespace RegexUserRegistration
{    /// <summary>
     /// UC 7 : As a User need to follow pre-defined Password rules.
     /// Rule 3 – Should have at least 1 numeric number in the password    
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

        }
    }
}