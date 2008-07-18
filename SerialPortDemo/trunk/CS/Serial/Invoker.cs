using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Serial
{
    public static class Invoker
    {
        public static void Invoke(Delegate delegateToCall, params object[] argsOfDelegateToCall)
        {
            foreach (Delegate del in delegateToCall.GetInvocationList())
            {
                ISynchronizeInvoke si = del.Target as ISynchronizeInvoke;
                if (si != null && si.InvokeRequired)
                    si.Invoke(del, argsOfDelegateToCall);
                else
                    del.DynamicInvoke(argsOfDelegateToCall);
            }
        }
    }
}