using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Customer
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = WorkType;
        }
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
