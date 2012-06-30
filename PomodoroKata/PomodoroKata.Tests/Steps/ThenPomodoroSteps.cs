namespace PomodoroKata.Tests.Steps
{
    using System;

    using FluentAssertions;

    using TechTalk.SpecFlow;

    [Binding]
    public class ThenPomodoroSteps
    {
        [Then(@"el pomodoro está parado")]
        public void ThenElPomodoroEstaParado()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.IsRunning.Should().Be(false);
            }

        [Then(@"el pomodoro está iniciado")]
        public void ThenElPomodoroEstaIniciado()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.IsRunning.Should().Be(true);
            }

        [Then(@"el pomodoro ha terminado")]
        public void EntoncesElPomodoroHaTerminado()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Finished.Should().Be(true);
        }

        [Then(@"el pomodoro no ha terminado")]
        public void EntoncesElPomodoroNoHaTerminado()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Finished.Should().Be(false);
        }

        [Then(@"la duración del pomodoro es de (\d+) minutos")]
        public void ThenLaDuracionDelPomodoroEsDe(int minutes)
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Duration.Minutes.Should().Be(minutes);
        }

        [Then(@"el número de interrupciones es (\d+)")]
        public void ElNumeroDeInterrupcionesEs(int breaks)
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Breaks.Should().Be(breaks);
        }
    }
}
