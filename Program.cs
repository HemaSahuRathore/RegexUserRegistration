namespace RegexUserRegistration
{   /// <summary>
    /// UC 4 : User need to follow pre-defined Mobile Format eg 91 9918596485
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

            Console.Write("\nEnter Mobile Number : ");
            string mobileNumber = Console.ReadLine();         
            UserRegistration.ValidateMobile(mobileNumber);

        }
    }
}