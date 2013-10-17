using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage.Tests
{
    class IntTestCaseSourceTests
    {
        [NUnit.Framework.Test]
        public void It_should_have_all_numbers_are_bigger_then_zero()
        {
            var numbers = 
            IntTestCaseSource.DecimalPositiveNumbers.GetFirstTestCaseValues<int>().ToArray();
            CollectionAssert.AllItemsAreUnique(numbers);
            Array.ForEach(numbers, x => Assert.IsTrue(x > 0));
        }
        [NUnit.Framework.Test]
        public void It_should_have_all_numbers_are_less_then_zero()
        {
            var numbers =
            IntTestCaseSource.DecimalNegativeNumbers.GetFirstTestCaseValues<int>().ToArray();
            CollectionAssert.AllItemsAreUnique(numbers);
            Array.ForEach(numbers, x => Assert.IsTrue(x < 0));
        }

        [Test]
        public void It_should_have_number_one_2_times_in_fibonaccie_numbers()
        {
            var fibNumbers = IntTestCaseSource.Fibonaccie.GetFirstTestCaseValues<int>();
            var number1s = fibNumbers.Where(x => x == 1);
            Assert.AreEqual(2, number1s.Count());
        }


        [Test]
        public void It_should_start_with_0_in_fibonaccie_numbers()
        {
            var fibNumbers = IntTestCaseSource.Fibonaccie.GetFirstTestCaseValues<int>();
            Assert.IsTrue(fibNumbers.Contains(0));
        }

    }
}
