using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class RandomStringTestCaseSource
    {
        #region Random

        private static Random random = new Random();

        private static string RandomString(int stringSize)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stringSize; i++)
            {
                var randomChar = Convert.ToChar(Convert.ToInt32(Math.Floor(72 * random.NextDouble() + 48)));
                sb.Append(randomChar);
            }
            return sb.ToString();
        }

        private static IEnumerable<string> RandomStrings(int numberOfString, int stringSize)
        {
            for (int i = 0; i < numberOfString; i++)
            {
                yield return RandomString(stringSize);
            }
        }



        #endregion
        public static IEnumerable<TestCaseData> String10by10
        {
            get
            {
                return RandomStrings(10, 10).ToTestCaseData();
            }
        }
    }
}