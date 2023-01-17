using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase2()
        {
            string lastname = "Radha";
            bool expected = true;
            bool actual = Pattern.validateLastName(lastname);
            Assert.AreEqual(expected, actual);
        }
        }
        }
