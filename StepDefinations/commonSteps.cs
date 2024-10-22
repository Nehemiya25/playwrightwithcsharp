using NUnit.Framework;
using TechTalk.SpecFlow;
using PlaywrightTests.Pages;


namespace PlaywrightTests.StepDefinitions
{
    [Binding] 
    public class commonSteps
    {
        private readonly UserManagementPage _userPage;
        public commonSteps(ScenarioContext context, UserManagementPage userPage)
        {
            _userPage = userPage;
            // _context = context;
        } [Then(@"user clicks on setup tab")]
         public async Task ThenUserClicksOnSetupTab()
         {
            await _userPage.clickOnSetupTab();
         }

         [Then(@"system should display account setup page")]
         public async Task ThenSystemShouldDisplayAccountSetupPage()
         {
            await _userPage.verifySetupPage();
         }

         [Then(@"user clicks on manage team members button")]
         public async Task ThenUserClicksOnManageTeamMembersButton()
         {
              await _userPage.clickOnManageTeam();
         }

         [Then(@"system should display teammembers page")]
         public async Task ThenSystemShouldDisplayTeammembersPage()
         {
              await _userPage.verifySetUpteamPage();
         }
         [Then(@"user click on Save and close button")]
         public async Task ThenUserClickOnSaveAndCloseButton()
         {
              await _userPage.clickOnSaveAndClose();
         }
         
         [Then(@"user search the account using last name")]
         public async Task usersearchtheaccountusinglastname()
         {
             await _userPage.searchAccount();
         }

    }
}