namespace PomodoroKata.Tests.Steps
{
    using System;

    using TechTalk.SpecFlow;

    [Binding]
    public class GivenPomodoroSteps
    {
        [Given(@"un pomodoro no iniciado")]
        public void GivenUnPomodoroNoIniciado()
        {
            var timer = new FakeTimer(null);
            var pomodoro = new Pomodoro(timer);
            ScenarioContext.Current.Set(pomodoro);
            ScenarioContext.Current.Set(timer);
        }

        [Given(@"un pomodoro iniciado")]
        public void GivenUnPomodoroIniciado()
        {
            var timer = new FakeTimer(null);
            var pomodoro = new Pomodoro(timer);
            SystemTime.Now = () => TestConstants.GeneralStartTime;
            pomodoro.Start();
            ScenarioContext.Current.Set(pomodoro);
            ScenarioContext.Current.Set(timer);
        }
    }
}