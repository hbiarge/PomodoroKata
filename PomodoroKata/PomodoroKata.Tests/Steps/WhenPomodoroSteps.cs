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
        [When(@"creo un nuevo pomodoro sin especificar su duración")]
        public void WhenCreoUnNuevoPomodoroSinEspecificarSuDuracion()
        {
            var timer = new FakeTimer(null);
            var pomodoro = new Pomodoro(timer);
            ScenarioContext.Current.Set(pomodoro);
            ScenarioContext.Current.Set(timer);
        }

        [When(@"creo un nuevo pomodoro espedificando una duración de (\d+) minutos")]
        public void WhenCreoUnNuevoPomodoroEspedificandounaDuracion(int minutes)
        {
            var timer = new FakeTimer(null);
            var pomodoro = new Pomodoro(timer, minutes);
            ScenarioContext.Current.Set(pomodoro);
            ScenarioContext.Current.Set(timer);
        }

        [When(@"lo inicio")]
        public void WhenLoInicio()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            SystemTime.Now = () => new DateTime(2012, 1, 1);
            pomodoro.Start();
        }

        [When(@"lo interrumpo")]
        public void WhenLoInterrumpo()
        {
            var pomodoro = ScenarioContext.Current.Get<Pomodoro>();
            pomodoro.Break();
        }

        [When(@"han pasado (\d+) minutos")]
        public void CuandoHanPasado(int minutes)
        {
            var timer = ScenarioContext.Current.Get<FakeTimer>();
            SystemTime.Now = () => TestConstants.GeneralStartTime.AddMinutes(minutes);
            timer.RaiseTickEvent();
        }
    }
}
