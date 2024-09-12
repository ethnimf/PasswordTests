using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordChecker.Tests;
using Password;

namespace Password.Tests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        [TestMethod]
        public void ValidatePassword_OnlyDigits_Return1()
        {
            // arrange
            string password = "123456";
            int expectedScore = 1;

            // act
            PasswordChecker validator = new PasswordChecker();
            int actualScore = validator.ValidatePassword(password);

            // assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void ValidatePassword_LowerAndUpperLetters_Return2()
        {
            // arrange
            string password = "abcABC";
            int expectedScore = 2;

            // act
            PasswordChecker validator = new PasswordChecker();
            int actualScore = validator.ValidatePassword(password);

            // assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void ValidatePassword_LettersAndDigits_Return3()
        {
            // arrange
            string password = "abcABC123";
            int expectedScore = 3;

            // act
            PasswordChecker validator = new PasswordChecker();
            int actualScore = validator.ValidatePassword(password);

            // assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void ValidatePassword_LettersDigitsSpecial_Return4()
        {
            // arrange
            string password = "abcABC123!";
            int expectedScore = 4;

            // act
            PasswordChecker validator = new PasswordChecker();
            int actualScore = validator.ValidatePassword(password);

            // assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void ValidatePassword_AllCriteriaMet_Return5()
        {
            // arrange
            string password = "abcABC123!@#12345";
            int expectedScore = 5;

            // act
            PasswordChecker validator = new PasswordChecker();
            int actualScore = validator.ValidatePassword(password);

            // assert
            Assert.AreEqual(expectedScore, actualScore);
        }
        
       
    }
}
