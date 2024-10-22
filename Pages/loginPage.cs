using Microsoft.Playwright;
using PlaywrightTests.pageObjects;
namespace PlaywrightTests.Pages
{
    public class LoginPage
    {
        private readonly IPage _page = null!;
        private readonly LoginUserPage loginUserPage = new LoginUserPage();
        public LoginPage(IPage page)
        {
            _page = page;
        }

        public async Task NavigateAsync()
        {
            await _page.GotoAsync(loginUserPage.url);
        }

        public async Task EnterCredentials()
        {
             await _page.WaitForTimeoutAsync(6000);
            await _page.FillAsync(loginUserPage.userNameInput, loginUserPage.username);
            await _page.FillAsync(loginUserPage.passwordInput, loginUserPage.password);
           
        }

        public async Task ClickLogin()
        {
            await _page.ClickAsync(loginUserPage.submitButton);
        }

        public async Task<bool> IsLoggedIn()
        {
            // await Task.Delay(90000);
            var accountPage = await _page.WaitForSelectorAsync(loginUserPage.dashBoardLabel);
            return accountPage != null;
        }
    }
}

