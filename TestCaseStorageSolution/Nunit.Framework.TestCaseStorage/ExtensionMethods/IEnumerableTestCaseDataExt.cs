using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class IEnumerableTestCaseDataExt
    {
        public static IEnumerable<TestCaseData> ToTestCaseData<T>(this IEnumerable<T> iEnumerable)
        {
            return ToTestCaseData(iEnumerable, x => x.ToString());
        }

        public static IEnumerable<TestCaseData> ToTestCaseData<T>(this IEnumerable<T> iEnumerable, string name)
        {
            return iEnumerable.Select(x => new TestCaseData(x).SetName(name));
        }

        public static IEnumerable<TestCaseData> ToTestCaseData<T>(this IEnumerable<T> iEnumerable, Func<T, string> nameSelector)
        {
            return iEnumerable.Select(x => new TestCaseData(x).SetName(nameSelector(x)));
        }

        public static IEnumerable<TestCaseData> ToTestCaseData<T, Tvalue>(this IEnumerable<T> iEnumerable, string name, Func<T, Tvalue> valueSelector)
        {
            return iEnumerable.Select(x => new TestCaseData(valueSelector(x)).SetName(name));
        }

        public static IEnumerable<TestCaseData> ToTestCaseData<T,Tvalue>(this IEnumerable<T> iEnumerable, Func<T, string> nameSelector, Func<T,Tvalue> valueSelector)
        {
            return iEnumerable.Select(x => new TestCaseData(valueSelector(x)).SetName(nameSelector(x)));
        }

        public static IEnumerable<T> GetFirstTestCaseValues<T>(this IEnumerable<TestCaseData> iEnumerableOfTestCaseData)
        {
            return iEnumerableOfTestCaseData.Select(x =>x.GetFirstTestCaseValue<T>());
        }
    }
}