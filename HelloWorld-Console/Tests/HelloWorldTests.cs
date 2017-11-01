using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld_Console;

namespace Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void ShouldReturnNameWith_Hello_OnValidNameInput()
        {
            string expectedResult = "Hello Mohammad!";
            string actualResult = Program.GetNameWithHello("Mohammad");

            Assert.AreEqual(expected: expectedResult, actual: actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowNullReferenceExceptionOn_EmptyOrNullNameInput()
        {
            Program.GetNameWithHello("");
        }
    }
}
