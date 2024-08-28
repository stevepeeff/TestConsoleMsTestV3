using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleMsTestV3
{
    /// <summary>
    ///  Example of making an TestAssembly an Executable:
    ///  https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-mstest-runner-intro
    /// </summary>
    [TestClass]
    public class TestExample
    {
        [TestMethod]
        public void TestSuccess()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestFailure()
        {
            Assert.Fail("This test must fail");
        }
    }
}