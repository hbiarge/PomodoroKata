using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroConsole
{
    using PomodoroKata;

    class Program
    {
        static void Main(string[] args)
        {
            var pomodoro = new Pomodoro(TimeSpan.FromSeconds(30));
            pomodoro.Start();

            Console.ReadLine();
        }
    }
}
