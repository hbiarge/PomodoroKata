using System;

namespace PomodoroConsole
{
    using PomodoroKata;

    class Program
    {
        static void Main(string[] args)
        {
            var timer = new ThreadingTimer(null, 0, 100);
            var pomodoro = new Pomodoro(timer, TimeSpan.FromSeconds(30));
            pomodoro.Start();

            Console.ReadLine();
        }
    }
}
