namespace PomodoroKata
{
    using System;

    public class Pomodoro
    {
        public Pomodoro()
        {
            Duration = TimeSpan.FromMinutes(25);
        }

        public Pomodoro(TimeSpan duration)
        {
            Duration = duration;
        }

        public bool IsRunning { get; private set; }

        public TimeSpan Duration { get; private set; }
    }
}
