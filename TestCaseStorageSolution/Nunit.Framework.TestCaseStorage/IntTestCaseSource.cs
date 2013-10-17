using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public class IntTestCaseSource
    {
        public static IEnumerable<TestCaseData> EdgeNumbers
        {
            get
            {
                yield return new TestCaseData(int.MaxValue);
                yield return new TestCaseData(int.MinValue);
            }
        }

        public static IEnumerable<TestCaseData> DecimalNegativeNumbers
        {
            get 
            {
                return GetDecimalNumbers().Select(x=>-1 * x).ToTestCaseData();
            }
        }

        public static IEnumerable<TestCaseData> DecimalPositiveNumbers
        {
            get
            {
                return GetDecimalNumbers().ToTestCaseData();
            }
        }

        public static IEnumerable<int> GetDecimalNumbers()
        {
            int returnNumber = 1;
            for (int i = 0; i < 10; i++)
            {
                yield return returnNumber;
                returnNumber *= 10;
            }
        }


        public static IEnumerable<TestCaseData> Sgn
        {
            get
            {
                yield return new TestCaseData(-1);
                yield return new TestCaseData(0); 
                yield return new TestCaseData(1);
            }
        }

        public static IEnumerable<TestCaseData> Fibonaccie
        {
            get
            {
                yield return new TestCaseData(0);	
                yield return new TestCaseData(1);	
                yield return new TestCaseData(1	);
                yield return new TestCaseData(2	);
                yield return new TestCaseData(3	);
                yield return new TestCaseData(5	);
                yield return new TestCaseData(8	);
                yield return new TestCaseData(13	);
                yield return new TestCaseData(21	);
                yield return new TestCaseData(34	);
                yield return new TestCaseData(55	);
                yield return new TestCaseData(89	);
                yield return new TestCaseData(144	);
                yield return new TestCaseData(233	);
                yield return new TestCaseData(377	);
                yield return new TestCaseData(610	);
                yield return new TestCaseData(987	);
                yield return new TestCaseData(1597	);
                yield return new TestCaseData(2584);
                yield return new TestCaseData(4181);
            }
        }
        

    }
}
