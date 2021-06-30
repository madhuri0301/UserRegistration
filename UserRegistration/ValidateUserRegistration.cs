﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class ValidateUserRegistration
    {
        private static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        private static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        private static string Regex_Email = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        private static string Regex_MobileNo = "^[9]{1}[1]{1}\\s[6-9]{1}[0-9]{9}$";
        private static string Regex_Password = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&+-.]*[!@#$%&+-.][^!@#$%&+-.]*$)[\\S]{8,}$";
       

        public bool ValidateFirstName(string FN)
        {
            try
            {
               
                Regex rg = new Regex(Regex_FirstName);
                return rg.IsMatch(FN);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_NAME, "Invalid User First Name.");
            }   
        }
        public bool ValidateLastName(string LN)
        {
            try
            {

                Regex rg = new Regex(Regex_LastName);
                return rg.IsMatch(LN);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_NAME, "Invalid User Last Name.");
            }
        }
        public bool ValidateEmail(string Email)
        {
            try
            {

                Regex rg = new Regex(Regex_Email);
                return rg.IsMatch(Email);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_EMAIL, "Invalid User Email.");
            }
        }
        public bool ValidateMobileNo(string MobileNo)
        {
            try
            {

                Regex rg = new Regex(Regex_MobileNo);
                return rg.IsMatch(MobileNo);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid User Mobile Number.");
            }
        }
        public bool ValidatePassword(string Password)
        {
            try
            {

                Regex rg = new Regex(Regex_Password);
                return rg.IsMatch(Password);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_PASSWORD, "Invalid User Password.");
            }
        }

        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
        public string CheckMultipleEmail(string Mail1, string Mail2, string Mail3)
        {
            ValidateUserRegistration Mail = new ValidateUserRegistration();
            bool MailEntry1 = Mail.ValidateEmail(Mail1);
            bool MailEntry2 = Mail.ValidateEmail(Mail2);
            bool MailEntry3 = Mail.ValidateEmail(Mail3);
            if (MailEntry1 && MailEntry2 && MailEntry3)
                return "Entry is Succesfull";
            else
                return "Entry is Fail";
        }

    }
}
