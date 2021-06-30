
using UserRegistration;
using System;
using NUnit.Framework;

namespace UserValidationTest
{
    public class Tests
    {

        //Happy Test Cases(Test Cases Pass The Entries)
        [Test]
        public void GivenUserFirstName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "Madhuri";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenInvalidFirstName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                bool result = user.ValidateFirstName("madhuri");

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid User First Name.", e.Message);
            }
        }
        [Test]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "Patil";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenInvalidLastName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                bool result = user.ValidateFirstName("patil");

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid User Last Name.", e.Message);
            }
        }
        [Test]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "harshupatil0301@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenInvalidEmail_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidateEmail("abc");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Email address.", e.Message);
            }
        }
        [Test]
        public void GivenInvalidEmail2_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidateEmail("12Har@.gmailcom");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Email address.", e.Message);
            }
        }

        [Test]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "91 6688342519";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenInvalidMobileNumber_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidateMobileNo("918888799769");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Mobile Number.", e.Message);
            }
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "Welcome@123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenInvalidPassword_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidatePassword("@Kfc");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Password.", e.Message);
            }
        }

        //Sad Test Cases(Test Cases Fail The Entry)
        [Test]
        public void GivenUserFirstName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "har";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "Pa";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "_harshupatil@gmail0301com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "916688342519";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "welcome123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void MultipleMail()
        {
            ValidateUserRegistration Mail = new ValidateUserRegistration();
            var Result = Mail.CheckMultipleEmail("Madhuri0301@gmail.com", "Krishna-100@yahoo.com", "Suhas12@gmail.com");
            Assert.AreEqual(Result, "Entry is Succesfull");
        }
    }
}