using NUnit.Framework;
using TechTalk.SpecFlow;
using PlaywrightTests.Pages;


namespace PlaywrightTests.StepDefinitions
{
    [Binding] 
    public class EditUserSteps
    {
        private readonly UserManagementPage _userPage=null!;

        public EditUserSteps(ScenarioContext context, UserManagementPage userPage)
        {
            _userPage = userPage;
        } 
        [Then(@"user clicks on edit button of first row")]
         public async Task userclicksoneditbuttonoffirsrow()
         {
             await _userPage.clickOnFirstRow();
         }
         [Then(@"user edits the first name of user")]
         public async Task usereditsthefirstnameofuser()
         {
             await _userPage.updateFirstName();
         }
    }
}