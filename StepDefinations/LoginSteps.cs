using NUnit.Framework;
using TechTalk.SpecFlow;
using PlaywrightTests.Pages;


namespace PlaywrightTests.StepDefinitions
{
    [Binding] 
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        
        public LoginSteps(ScenarioContext context, LoginPage loginPage)
        {
            _loginPage = loginPage;
        }
        
        [Given(@"user navigate to the login page")]
        public async Task usernavigatetotheloginpage()
        {
            await _loginPage.NavigateAsync();
        }
        [When(@"user enter valid credentials")]
        public async Task userentervalidcredentials()
        {
           await _loginPage.EnterCredentials();
           await _loginPage.ClickLogin();
        }
        
        [Then(@"user should be logged in successfully")]
        public async Task usershouldbeloggedinsuccessfully()
        {
            Assert.True(await _loginPage.IsLoggedIn());
        }
    }
}
