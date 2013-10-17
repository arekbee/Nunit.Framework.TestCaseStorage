using System.Collections.Generic;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class StringTestCaseSource
    {
        public static IEnumerable<TestCaseData> NullAndWhiteSpaceStrings
        {
            get
            {
                yield return new TestCaseData(null);
                yield return new TestCaseData("");
                yield return new TestCaseData(" ");
            }
        }

        public static IEnumerable<TestCaseData> Urls
        {
            get
            {
                yield return new TestCaseData("http://arekonsoftware.pl/");
                yield return new TestCaseData("https://arekonsoftware.pl/");
            }
        }

        public static IEnumerable<TestCaseData> FilePath
        {
            get
            {
                yield return new TestCaseData(@"C:\WINDOWS\NOTEPAD.EXE");
            }
        }

        public static IEnumerable<TestCaseData> LongNumbers
        {
            get
            {
                yield return new TestCaseData(long.MaxValue.ToString());
                yield return new TestCaseData(long.MinValue.ToString());
                yield return new TestCaseData("0");
            }
        }

        public static IEnumerable<TestCaseData> Zeros
        {
            get
            {
                yield return new TestCaseData("0");
                yield return new TestCaseData("00");
                yield return new TestCaseData("000");
                yield return new TestCaseData("0000");
                yield return new TestCaseData("00000");
                yield return new TestCaseData("000000");
                yield return new TestCaseData("0000000");
                yield return new TestCaseData("00000000");
                yield return new TestCaseData("000000000");
                yield return new TestCaseData("0000000000");
            }
        }

        public static IEnumerable<TestCaseData> LoremIpsum
        {
            get
            {
                yield return new TestCaseData("Lorem ipsum dolor sit amet, consectetur adipisicing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam. Quisque semper justo at risus. Donec venenatis, turpis vel hendrerit interdum, dui ligula ultricies purus, sed posuere libero dui id orci. Nam congue, pede vitae dapibus aliquet, elit magna vulputate arcu, vel tempus metus leo non est. Etiam sit amet lectus quis est congue mollis. Phasellus congue lacus eget neque. Phasellus ornare, ante vitae consectetuer consequat, purus sapien ultricies dolor, et mollis pede metus eget nisi. Praesent sodales velit quis augue. Cras suscipit, urna at aliquam rhoncus, urna quam viverra nisi, in interdum massa nibh nec erat.");
            }
        }
    }
}