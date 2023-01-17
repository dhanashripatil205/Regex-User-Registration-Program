using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {            
            string name = "Krishna";
            bool expected = true;            
            bool actual = Pattern.validateName(name);
            Assert.AreEqual(expected, actual);
        }
        }
        }
