using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class EnumTestCaseSource<T>
    {
        public static IEnumerable<TestCaseData> Names
        {
            get
            {
                return Enum.GetNames(typeof(T)).Select(x => new TestCaseData(x));
            }
        }
        public static IEnumerable<TestCaseData> Values
        {
            get
            {
                return Enum.GetValues(typeof(T)).Cast<T>().ToTestCaseData();
            }
        }
    }
}