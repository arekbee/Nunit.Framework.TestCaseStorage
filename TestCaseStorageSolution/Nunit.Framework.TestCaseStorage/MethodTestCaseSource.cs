using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Nunit.Framework.TestCaseStorage
{
    public static class MethodTestCaseSource<T>
    {
        public static IEnumerable<MethodInfo> GetInstanceMethods()
        {
            return typeof(T).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
                .Where(x => !x.IsStatic)
                .Where(x => !x.IsAbstract && x.IsPublic)
                ;
        }

        public static IEnumerable<MethodInfo> GetStaticMethods()
        {
            return typeof(T).GetMethods(BindingFlags.Static | BindingFlags.Public)
                .Where(x => x.IsStatic)
                ;
        }

        public static IEnumerable<TestCaseData> NonStatic
        {
            get
            {
                var methods = GetInstanceMethods()
                    .Where(x => x.ReturnType == typeof(void));

                var methodInvokers = MethodInvoker.ToInvoker(methods);
                return methodInvokers
                    .ToTestCaseData(x => x.Method.Name);
            }
        }

    }
    public static class MethodTestCaseSource<T, TReturn>
    {

        public static IEnumerable<TestCaseData> Static
        {
            get
            {
                var methodInfos = MethodTestCaseSource<T>.GetStaticMethods()
                     .Where(x => x.ReturnType == typeof(TReturn));
                var methodInvokers = MethodInvoker<TReturn>.ToInvoker(methodInfos);
                return methodInvokers
                    .ToTestCaseData(x => x.Method.Name);
            }
        }

        public static IEnumerable<TestCaseData> NonStatic
        {
            get
            {
                var methods = MethodTestCaseSource<T>.GetInstanceMethods()
                    .Where(x => x.ReturnType == typeof(T));

                var methodInvokers = MethodInvoker.ToInvoker(methods);
                return methodInvokers
                    .ToTestCaseData(x => x.Method.Name);
            }
        }






    }
}