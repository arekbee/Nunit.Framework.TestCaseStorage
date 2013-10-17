using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace Nunit.Framework.TestCaseStorage.Tests
{
    public class StringTestCaseSourceTests
    {
        [Test]
        public void It_should_return_sandard_strings_to_test()
        {
            var strings = StringTestCaseSource.NullAndWhiteSpaceStrings
                            .GetFirstTestCaseValues<string>();
            CollectionAssert.Contains(strings, null);
            CollectionAssert.Contains(strings, string.Empty);
            CollectionAssert.Contains(strings, " ");
        }

        [Test]
        public void It_should_start_with_http()
        {
            var urls = StringTestCaseSource.Urls
                .GetFirstTestCaseValues<string>()
                .ToArray();
            Array.ForEach(urls, x=> StringAssert.StartsWith("http",x));
        }

        [Test]
        public void It_should_exist_file_path()
        {
            var filePath = StringTestCaseSource.FilePath.GetFirstTestCaseValues<string>().ToArray();
            Array.ForEach(filePath, x => Assert.IsTrue(File.Exists( x)));
        }

        [Test]
        public void It_should_return_long_numbers()
        {
            var longNumbers = StringTestCaseSource.LongNumbers
                .GetFirstTestCaseValues<string>()
                .ToArray();
            Array.ForEach(longNumbers, x =>{
                                               long outLong;
                                               Assert.IsTrue(long.TryParse(x,out outLong));
                                           });
        }

        [Test]
        public void It_should_return_zeros()
        {
            var zeroStrings = StringTestCaseSource.Zeros
                .GetFirstTestCaseValues<string>()
                .ToArray();
            Array.ForEach(zeroStrings, x =>{
                                               int outInt;
                                               Assert.IsTrue(int.TryParse(x,out outInt));
                                               Assert.AreEqual(0, outInt);
                                           });
            
        }

        [Test]
        public void It_should_return_long_loremIpsum_string()
        {
            var longStrings = StringTestCaseSource.LoremIpsum.GetFirstTestCaseValues<string>().ToArray();
            Assert.IsTrue(longStrings.Any());
            Array.ForEach(longStrings, x =>
                                           {
                                               Assert.IsTrue(x.Length > 100);
                                               StringAssert.StartsWith("Lorem", x);
                                           }
            );

        }
    }
}
