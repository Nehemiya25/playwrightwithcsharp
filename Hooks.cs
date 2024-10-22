using BoDi;
using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace PlaywrightTests
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public async Task BeforeScenarioAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Channel = "msedge",
                Headless = false
            });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://rta-edu-stg-web-03.azurewebsites.net/core");
            _objectContainer.RegisterInstanceAs(browser);
            _objectContainer.RegisterInstanceAs(page);
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            var browser = _objectContainer.Resolve<IBrowser>();
            await browser.CloseAsync();
        }
    }
}
