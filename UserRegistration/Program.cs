using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validateUserRegistration.ValidateFirstName(firstName); //Validating First Name Of User
            validateUserRegistration.PrintResult(fNameResult); // Printing first Name Of User
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validateUserRegistration.ValidateFirstName(lastName); //Validating Last Name Of User
            validateUserRegistration.PrintResult(lNameResult); //Printing Last Name Of User
        }
    }
}
