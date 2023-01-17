using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {      
        [TestMethod]
        public void UseCase6()
        {
            string password = "Krishnap";
            bool expected = true;
            bool actual = Pattern.validatePassword1(password);
            Assert.AreEqual(expected, actual);
        }
        }
        }
