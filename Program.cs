namespace RegexUserRegistration
{   /// <summary>
    /// UC 3 : As a User need to enter a valid email
    /// - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions
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

        }
    }
}