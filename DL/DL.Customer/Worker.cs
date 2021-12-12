using System;

namespace DL.Customer
{

    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted;
            if (del!=null)
            {
                del(this, EventArgs.Empty);
            }
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed(this, new WorkPerformedEventArgs(hours, workType));
            }
        }
    }

    public enum WorkType
    {
        GenerateReport,
        Logistics
    }
}
