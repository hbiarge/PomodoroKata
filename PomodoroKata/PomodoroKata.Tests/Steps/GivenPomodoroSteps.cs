namespace PomodoroKata.Tests.Steps
{
    using TechTalk.SpecFlow;

    [Binding]
    public class GivenPomodoroSteps
    {
        [Given(@"Un pomodoro no iniciado")]
        public void GivenUnPomodoroNoIniciado()
        {
            var pomodoro = new Pomodoro();
            ScenarioContext.Current.Set(pomodoro);
        }

        [Given(@"Un pomodoro iniciado")]
        public void GivenUnPomodoroIniciado()
        {
            var pomodoro = new Pomodoro();
            pomodoro.Start();
            ScenarioContext.Current.Set(pomodoro);
        }
    }
}