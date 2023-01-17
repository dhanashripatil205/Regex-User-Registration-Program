using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase5()
        {
            string password = "krishnap";
            bool expected = true;
            bool actual = Pattern.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        }
        }
