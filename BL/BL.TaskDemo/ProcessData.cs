using System;
using System.Collections.Generic;
using System.Text;

namespace BL.TaskDemo
{

    /// <summary>
    /// delegate to decide the process to follow according the business rules.
    /// </summary>
    /// <param name="x">int to process</param>
    /// <param name="y">int to process</param>
    /// <returns></returns>
    public delegate int BizRulesDelegate(int x, int y);
    public class ProcessData
    {
        public void Process(int x, int y, BizRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine($"The result is: {result}");
        }

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine($"Action has been processed");
        }
    }
}
