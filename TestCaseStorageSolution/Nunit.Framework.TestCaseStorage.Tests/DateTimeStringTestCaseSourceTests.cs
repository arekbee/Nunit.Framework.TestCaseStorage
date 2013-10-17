using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage.Tests
{
    public class DateTimeStringTestCaseSourceTests
    {
        [Test]
        public void It_should_return_32_days()
        {
            var iterDateTime = DateTimeStringTestCaseSource.GetIterDateTime();
            Assert.AreEqual(32, iterDateTime.Count());
        }
    }
}
