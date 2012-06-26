using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PomodoroKata.Tests.Steps
{
    [Binding]
    public class WhenPomodoroSteps
    {
        [When(@"Creo un nuevo pomodoro sin especificar su duración")]
        public void WhenCreoUnNuevoPomodoroSinEspecificarSuDuracion()
        {
            ScenarioContext.Current.Set(new Pomodoro());
        }

        [When(@"Creo un nuevo pomodoro espedificando una duración de (\d+) minutos")]
        public void WhenCreoUnNuevoPomodoroEspedificandounaDuracion(int minutes)
        {
            ScenarioContext.Current.Set(new Pomodoro(TimeSpan.FromMinutes(minutes)));
        }

        [When(@"lo inicio")]
        public void WhenLoInicio()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Start();
        }

        [When(@"lo interrumpo")]
        public void WhenLoInterrumpo()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Break();
        }
    }
}
