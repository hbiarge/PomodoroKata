using System;

namespace PomodoroKata
{
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs(object state)
        {
            this.State = state;
        }

        public object State { get; private set; }
    }

    public delegate void TimerEventHandler(object sender, TimerEventArgs e);
}
