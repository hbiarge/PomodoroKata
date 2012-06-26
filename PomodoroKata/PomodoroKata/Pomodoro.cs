namespace PomodoroKata
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class Pomodoro : IDisposable
    {
        private DateTime startTime;
        private readonly Timer timer;

        public Pomodoro()
        {
            this.Duration = TimeSpan.FromMinutes(25);
            this.timer = new Timer(this.TimerTick, null, int.MaxValue, 1000);
        }

        public Pomodoro(TimeSpan duration)
        {
            this.Duration = duration;
            this.timer = new Timer(this.TimerTick, null, int.MaxValue, 100);
        }

        public bool IsRunning { get; private set; }

        public TimeSpan Duration { get; private set; }

        public int Breaks { get; private set; }

        public void Start()
        {
            this.startTime = DateTime.Now;
            this.IsRunning = true;

            this.timer.Change(0, 100);
        }

        public void Break()
        {
            if (this.IsRunning)
            {
                this.Breaks++;
            }
        }

        private void TimerTick(object state)
        {
            var timeElapsed = DateTime.Now.Subtract(this.startTime);
            Debug.WriteLine(timeElapsed);

            if (timeElapsed <= this.Duration)
            {
                return;
            }

            this.timer.Change(int.MaxValue, 100);
            this.IsRunning = false;
            this.startTime = DateTime.MinValue;
        }

        public void Dispose()
        {
            if (this.timer != null)
            {
                this.timer.Dispose();
            }
        }
    }
}
