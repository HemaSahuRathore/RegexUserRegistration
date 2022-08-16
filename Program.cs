namespace RegexUserRegistration
{   /// <summary>
    /// UC 1 : As a User need to enter a valid First Name
    /// - First name starts with Cap and hasminimum 3 characters
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem"); //welcome msg
            Console.Write("\nEnter your First Name : ");
            string firstName = Console.ReadLine();
            UserRegistration.ValidateName(firstName);

            Console.Write("\nEnter your Last Name : ");
            string lastName = Console.ReadLine();
            UserRegistration.ValidateName(lastName);

            Console.Write("Email ID : ");
            string emailId = Console.ReadLine();
            Console.ReadLine();
        }
    }
}