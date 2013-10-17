using System.Linq;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class TestCaseDataExt
    {
        public static T GetFirstTestCaseValue<T>(this TestCaseData testCaseData)
        {
            return (T)testCaseData.Arguments.First();
        }

        public static object GetFirstTestCaseValue(this TestCaseData testCaseData)
        {
            return GetFirstTestCaseValue<object>(testCaseData);
        }
    }
}