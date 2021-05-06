using NUnit.Framework;
using CS1410_final;
using System;

namespace NUnitTestProject
{
    public class Tests
    {
         

        [SetUp]
       public void SetUp()
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
      
        
    }
    
        
}