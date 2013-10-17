using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Nunit.Framework.TestCaseStorage
{
    public class MethodInvoker
    {
        public MethodInfo Method { get; private set; }
        public MethodInvoker(MethodInfo methodInfo)
        {
            Method = methodInfo;
        }
        public void Invoke(object obj = null, object[] parameters = null)
        {
            Method.Invoke(obj, parameters);
        }

        public static IEnumerable<MethodInvoker> ToInvoker(IEnumerable<MethodInfo> methodInfos)
        {
            return methodInfos.Select(x => new MethodInvoker(x));
        }
    }


    public class MethodInvoker<TReturn> : MethodInvoker
    {
        public MethodInvoker(MethodInfo methodInfo) : base(methodInfo) { }

        public TReturn Invoke(object obj = null, object[] parameters = null)
        {
            return (TReturn)Method.Invoke(obj, parameters);
        }

        public static IEnumerable<MethodInvoker<TReturn>> ToInvoker(IEnumerable<MethodInfo> methodInfos)
        {
            return methodInfos.Select(x => new MethodInvoker<TReturn>(x));
        }
    }
}