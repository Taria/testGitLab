using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistratinML;

namespace RegistrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyInput()
        {
            // Arranges
            string uName = "";
            string uPass = "sgsdgdfhgfj";
            Registration registration = new Registration();

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => registration.Login(uName, uPass));
        }

        [TestMethod]
        public void NullInput()
        {
            // Arrange
            string uName = "dfghdfhfgnjxed";
            string uPass = null;
            Registration registration = new Registration();

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => registration.Login(uName, uPass));
        }

        [TestMethod]
        public void ShortInput()
        {
            // Arrange
            string uName = "1234567";
            string uPass = "sgsdgdfhgfj";
            Registration registration = new Registration();

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => registration.Login(uName, uPass));
        }

        [TestMethod]
        public void LongInput()
        {
            // Arrange
            string uName = "1234567890123456789012345678901";
            string uPass = "sgsdgdfhgfj";
            Registration registration = new Registration();

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => registration.Login(uName, uPass));
        }

        [TestMethod]
        public void MinOkInput()
        {
            // Arrange
            string uName = "12345678";
            string uPass = "sgsdgdfhgfj";
            Registration registration = new Registration();

            // Act
            int res = registration.Login(uName, uPass);

            // Assert
            Assert.AreEqual(0, res, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void MaxOkInput()
        {
            // Arrange
            string uName = "123456789012345678901234567890";
            string uPass = "sgsdgdfhgfj";
            Registration registration = new Registration();

            // Act
            int res = registration.Login(uName, uPass);

            // Assert
            Assert.AreEqual(0, res, 0.001, "Account not debited correctly");
        }
    }
}
