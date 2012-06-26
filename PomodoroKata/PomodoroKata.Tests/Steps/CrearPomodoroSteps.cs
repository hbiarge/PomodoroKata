namespace PomodoroKata.Tests.Steps
{
    using System;

    using FluentAssertions;

    using TechTalk.SpecFlow;

    [Binding]
    public class CrearPomodoroSteps
    {
        private Pomodoro pomodoro;

        [Given(@"No se ha creado todavía un pomodoro")]
        public void GivenNoSeHaCreadoTodaviaUnPomodoro()
        {
            pomodoro = null;
        }

        [When(@"Creo un nuevo pomodoro espedificandouna duración de 30 minutos")]
        public void WhenCreoUnNuevoPomodoroEspedificandounaDuracionDe30Minutos()
        {
            pomodoro = new Pomodoro(TimeSpan.FromMinutes(30));
        }

        [When(@"Creo un nuevo pomodoro sin especificar su duración")]
        public void WhenCreoUnNuevoPomodoroSinEspecificarSuDuracion()
        {
            pomodoro = new Pomodoro();
        }

        [Then(@"el pomodoro está parado")]
        public void ThenElPomodoroEstaParado()
        {
            pomodoro.IsRunning.Should().Be(false);
        }

        [Then(@"la duración del pomodoro es de (\d+) minutos")]
        public void ThenLaDuracionDelPomodoroEsDe25Minutos(int minutes)
        {
            pomodoro.Duration.Minutes.Should().Be(minutes);
        }
    }
}
