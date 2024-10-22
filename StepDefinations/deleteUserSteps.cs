using NUnit.Framework;
using TechTalk.SpecFlow;
using PlaywrightTests.Pages;


namespace PlaywrightTests.StepDefinitions
{
    [Binding] 
    public class DeleteUserSteps
    {
        private readonly UserManagementPage _userPage=null!;

        public DeleteUserSteps(ScenarioContext context, UserManagementPage userPage)
        {
            _userPage = userPage;

        } 
          [Then(@"user click on delete button")]
         public async Task userclickondeletebutton()
         {
             await _userPage.clickOnDelete();
             await _userPage.clickOnDeletePoup();
         }
         [Then(@"user clicks on close button")]
         public async Task userclickonclosebutton()
         {
            await _userPage.clickOnClose();
         }
         [Then(@"user verify the account is deleted")]
         public async Task userverifytheaccountisdeleted()
         {
            Assert.IsFalse(await _userPage.verifyAccountDelete());
         }
    }
}
