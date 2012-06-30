namespace PomodoroKata
{
    public interface ITimer
    {
        void Change(int dueTime, int period);
        event TimerEventHandler Tick;
    }
}
