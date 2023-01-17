using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void UseCase7()
        {
            string password = "Dhanas8w";
            bool expected = true;
            bool actual = Pattern.validatePassword2(password);
            Assert.AreEqual(expected, actual);
        }
        }
        }
