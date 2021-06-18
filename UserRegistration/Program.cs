using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //class and it's object
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();

            //firstname
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validateUserRegistration.ValidateFirstName(firstName); //Validating First Name Of User
            validateUserRegistration.PrintResult(fNameResult); // Printing first Name Of User

            //lastname
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validateUserRegistration.ValidateFirstName(lastName); //Validating Last Name Of User
            validateUserRegistration.PrintResult(lNameResult); //Printing Last Name Of User

            //emailId
            Console.WriteLine("Enter your email : ");
            string email = Console.ReadLine();
            bool emailResult = validateUserRegistration.ValidateEmail(email); //Validating email Of User
            validateUserRegistration.PrintResult(emailResult); //Print Email Of User

            Console.WriteLine("Enter your mobile number : ");
            string mobileNo = Console.ReadLine();
            bool mobileNoResult = validateUserRegistration.ValidateMobileNo(mobileNo); //Validiating Mobile Number Of User
            validateUserRegistration.PrintResult(mobileNoResult); //Print Mobile Number Of User
        }
    }
}
