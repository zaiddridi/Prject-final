using NUnit.Framework;
using CS1410_final;
using System;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var actif = Utility.GetValidDecimalInputAmt("64354");
            Int64 expected = 64354;
            Assert.IsTrue(expected.Equals(actif));
        }
        [Test]
        public void Test2()
        {
            var actif = Utility.GetValidIntInputAmt("54545");
            Int64 expected = 55545;
            Assert.IsTrue(expected.Equals(actif));
        }
        [Test]
        public void Test3()
        {
            var BankAccount = new BankAccount() { FullName = "John", AccountNumber = 333111, CardNumber = 123, PinCode = 111111, Balance = 2000.00m, isLocked = false };
            
        }
        [Test]
        public void Test4()
        {
            String message = "this is a test";
            var actif = Utility.GetRawInput( message);
            var expected = message;
            Assert.IsTrue(expected.Equals(actif));
        }
    }
}