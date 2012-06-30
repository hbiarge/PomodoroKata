using System;
using System.Diagnostics;

namespace PomodoroKata
{
    public class Pomodoro : IDisposable
    {
        private readonly ITimer timer;

        public Pomodoro(ITimer timer, int duration = 25)
        {
            this.Duration = TimeSpan.FromMinutes(duration);
            this.timer = timer;
            this.timer.Tick += this.TimerTick;
        }

        public DateTime StartedAt { get; private set; }

        public bool IsRunning { get; private set; }
        
        public bool Finished { get; private set; }

        public TimeSpan Duration { get; private set; }

        public int Breaks { get; private set; }

        public void Start()
        {
            this.StartedAt = SystemTime.Now();
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

        public void Dispose()
        {
            this.timer.Tick -= this.TimerTick;
            var disposable = this.timer as IDisposable;

            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        private void TimerTick(object sender, TimerEventArgs e)
        {
            if (this.IsRunning == false)
            {
                return;
            }

            var timeElapsed = SystemTime.Now().Subtract(this.StartedAt);

            if (timeElapsed <= this.Duration)
            {
                return;
            }

            this.timer.Change(int.MaxValue, 100);
            this.IsRunning = false;
            this.Finished = true;
            this.StartedAt = DateTime.MinValue;
        }
    }
}
