using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroKata.Tests
{
    public class FakeTimer : ITimer
    {
        private readonly object state;

        public event TimerEventHandler Tick;

        public FakeTimer(object state)
        {
            this.state = state;
        }

        public void Change(int dueTime, int period)
        {
            // Do nothing
        }

        public void RaiseTickEvent()
        {
            var tick = Tick;
            if (tick != null)
            {
                tick(this, new TimerEventArgs(state));
            }
        }
    }
}
