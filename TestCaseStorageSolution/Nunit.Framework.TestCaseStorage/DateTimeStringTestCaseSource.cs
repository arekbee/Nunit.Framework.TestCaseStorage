using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class DateTimeStringTestCaseSource
    {
        public const string SimpleDateTimeFormat = "yyyyMMdd";

        public static IEnumerable<TestCaseData> Simple
        {
            get
            {
                return GetSpecificDateTime().ToTestCaseData("Simple", x => x.ToString(SimpleDateTimeFormat));
            }
        }

        public static IEnumerable<TestCaseData> ShortDate
        {
            get
            {
                return GetSpecificDateTime().ToTestCaseData(x => MethodBase.GetCurrentMethod().Name.Substring(5), x => x.ToShortDateString());
            }
        }


        public static IEnumerable<TestCaseData> EdgeSimpleDate
        {
            get
            {
                return GetEdgeDateTime().ToTestCaseData(x => MethodBase.GetCurrentMethod().Name.Substring(5), x => x.ToString(SimpleDateTimeFormat));
            }
        }


        public static  IEnumerable<DateTime> GetSpecificDateTime()
        {
            yield return new DateTime(2000,1,1);
            yield return new DateTime(1, 1, 1);
            yield return new DateTime(2000, 2, 28);
            yield return new DateTime(1990, 3, 25);


            yield return new DateTime(1753,01,01); //MS SQL Server datetime
            yield return new DateTime(2079,06,06); //MS SQL Server smalldatetime

        }

        public static IEnumerable<DateTime> GetEdgeDateTime()
        {
            yield return DateTime.MaxValue;
            yield return DateTime.MinValue;
            yield return new DateTime(1752, 12, 31); //Below MS SQL Server datetime
            yield return new DateTime(2079,06,07); //Above MS SQL Server smalldatetime
        }

        public static IEnumerable<DateTime> GetIterDateTime()
        {
            DateTime returndatetime= new DateTime(2010,10,1);
            for (int i = 0; i < 32; i++)
            {
                yield return returndatetime;
                returndatetime = returndatetime.AddDays(1);
            }
        }

    }
}
