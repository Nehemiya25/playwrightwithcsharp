using NUnit.Framework;
using TechTalk.SpecFlow;
using PlaywrightTests.Pages;


namespace PlaywrightTests.StepDefinitions
{
    [Binding] 
    public class AddUser
    {
        private readonly UserManagementPage _userPage=null!;

        public AddUser(ScenarioContext context, UserManagementPage userPage)
        {
            _userPage = userPage;
          //   _context = context;
        } 
         [Then(@"user clicks on Add Team Member button")]
         public async Task ThenUserClicksOnAddTeamMemberButton()
         {
              await _userPage.clickOnAddTeamMember();
         }

         [Then(@"user fill all the mandatory fields")]
         public async Task ThenUserFillAllTheMandatoryFields()
         {
              await _userPage.fillMandatoryFieldsTeam();
         }
          [Then(@"user enters the created account name")]
         public async Task ThenUserEntersTheCreatedAccountName()
         {
              await _userPage.enterAccountname();
         }

         [Then(@"system should display the account details")]
         public async Task ThenSystemShouldDisplayTheAccountDetails()
         {
              await _userPage.verifyAccountSearch();
         }
          [Then(@"user verify the updated changes")]
         public async Task userverifytheupdatedchanges()
         {
             await _userPage.verifyUpdate();
         }
    }
}
