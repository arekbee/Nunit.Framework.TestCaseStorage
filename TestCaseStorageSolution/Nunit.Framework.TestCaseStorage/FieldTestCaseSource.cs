using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class FieldTestCaseSource<T>
    {
        public static IEnumerable<TestCaseData> Static
        {
            get
            {
                var propertyInfos = typeof(T).GetFields()
                    .Where(x => x.IsStatic)
                    .Select(x => new {Value= x.GetValue(null), x.Name})
                    ;
                return propertyInfos.ToTestCaseData(x=>x.Name, x=>x.Value);
            }
        }
    }
}