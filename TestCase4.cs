using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void UseCase4()
        {
            string mb = "91 7985369532";
            bool expected = true;
            bool actual = Pattern.validateMobileNumber(mb);
            Assert.AreEqual(expected, actual);
        }
       
        }
        }
        
