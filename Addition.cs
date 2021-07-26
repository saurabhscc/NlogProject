using System;
using System.Collections.Generic;
using System.Text;

namespace NlogProject
{
    public class Addition
    {
        static NLog nlog = new NLog();
        public static int add(int firstnumber,int secondnumber)
        {
            if (firstnumber == 0 || secondnumber == 0)
            {
                nlog.LogInfo("Add method");
                nlog.LogDebug("Debug Successful");
                nlog.LogError(" first number or second number is zero");
                return 0;
            }
               
            int result = firstnumber + secondnumber;
            nlog.LogInfo("Add method");
            nlog.LogDebug("Debug Successful");
            nlog.LogWarn(" first number or second number is zero");
            return result;
        }
       
    }
}
