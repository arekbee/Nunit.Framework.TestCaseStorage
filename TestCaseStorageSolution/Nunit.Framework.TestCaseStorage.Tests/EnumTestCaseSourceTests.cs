using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage.Tests
{
    public enum SimpleEnum2
    {
        Value1 =1,
        Value2 =2
    }


    public class EnumTestCaseSourceTests
    {
        [Test]
        public void It_should_return_all_elements_in_enum_for_names()
        {
            var names = EnumTestCaseSource<SimpleEnum2>.Names;
            Assert.AreEqual(2, names.Count());
        }
        [Test]
        public void It_should_return_all_elements_in_enum_for_values()
        {
            var values = EnumTestCaseSource<SimpleEnum2>.Values;
            Assert.AreEqual(2, values.Count());
        }

        [Test]
        public void It_should_return_name_of_first_enum_item()
        {
            var fisrtname = EnumTestCaseSource<SimpleEnum2>.Names.First();
            var fisrtnameValue = fisrtname.GetFirstTestCaseValue();
            Assert.AreEqual("Value1", fisrtnameValue);
        }

        [Test]
        public void It_should_return_value_of_second_item()
        {
            var secondValue = EnumTestCaseSource<SimpleEnum2>.Values
                .Skip(1)
                .First()
                .GetFirstTestCaseValue();
            Assert.AreEqual(SimpleEnum2.Value2, secondValue);
        }


    }
}
