using System;

namespace PomodoroKata
{
    using System.Threading;

    public class ThreadingTimer : ITimer, IDisposable
    {
        private readonly Timer timer;

        public event TimerEventHandler Tick;

        public ThreadingTimer(object state, int dueTime, int period)
        {
            timer = new Timer(TimerCallback, state, dueTime, period);
        }

        public void Change(int dueTime, int period)
        {
            timer.Change(dueTime, period);
        }

        public void Dispose()
        {
            timer.Dispose();
        }

        private void TimerCallback(object state)
        {
            var tick = Tick;

            if (tick != null)
            {
                tick(this, new TimerEventArgs(state));
            }
        }
    }

}
