using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage.Tests
{
    public class DateTimeRequiredFormats
    {
        public const string Req1 = "yyyyMMdd"; //const is 
        public readonly static string Req2 = "yyyy  MM  dd";
        public static string Req3 = "yyyy MM dd";
        public string Req4 = ""; //not used because not static


        ////////////
        public string Req5 { get { return "a"; } }
        public string Req6 { get; set; }

        public DateTimeRequiredFormats(string req6)
        {
            Req6 = req6;
        }

    }

    public class FieldTestCaseSourceTests
    {

        [Test]
        public void It_should_MethodName()
        {
            var allStaticFields = FieldTestCaseSource<DateTimeRequiredFormats>.Static;
            Assert.AreEqual(3, allStaticFields.Count());
            var fieldsNames = allStaticFields.Select(x=>x.TestName);
            CollectionAssert.Contains(fieldsNames, "Req1");
            CollectionAssert.Contains(fieldsNames, "Req3");
            CollectionAssert.Contains(fieldsNames, "Req2");
        }



    }
}
