using System;

namespace PomodoroKata
{
    public static class SystemTime
    {
        public static Func<DateTime> Now = () => DateTime.Now;
    }
}
