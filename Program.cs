namespace RegexUserRegistration
{   /// <summary>
    /// UC 2 : As a User need to enter a valid last Name
    /// - Last name starts with Cap and has minimum 3 characters
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

        }
    }
}