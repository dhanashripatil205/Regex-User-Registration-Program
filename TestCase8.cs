using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase8()
        {
            string password = "Kifnj@78a";
            bool expected = true;
            bool actual = Pattern.validatePassword3(password);
            Assert.AreEqual(expected, actual);
        }
        }
        }
