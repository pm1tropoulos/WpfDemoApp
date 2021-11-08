using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Customer
{

    public delegate int WorkPerformedHandler(int hours, WorkType workType);
    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {

        }

    }

    public enum WorkType
    {
        GenerateReport,
        Logistics
    }
}
