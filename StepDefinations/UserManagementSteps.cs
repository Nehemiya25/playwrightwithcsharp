// using NUnit.Framework;
// using TechTalk.SpecFlow;
// using PlaywrightTests.Pages;


// namespace PlaywrightTests.StepDefinitions
// {
//     [Binding] 
//     public class UserManagementSteps
//     {
//         private readonly UserManagementPage _userPage=null!;

//         public UserManagementSteps(ScenarioContext context, UserManagementPage userPage)
//         {
//             _userPage = userPage;
//           //   _context = context;
//         } 
     // [Then(@"user clicks on setup tab")]
     //     public async Task ThenUserClicksOnSetupTab()
     //     {
     //        await _userPage.clickOnSetupTab();
     //     }

     //     [Then(@"system should display account setup page")]
     //     public async Task ThenSystemShouldDisplayAccountSetupPage()
     //     {
     //        await _userPage.verifySetupPage();
     //     }

     //     [Then(@"user clicks on manage team members button")]
     //     public async Task ThenUserClicksOnManageTeamMembersButton()
     //     {
     //          await _userPage.clickOnManageTeam();
     //     }

     //     [Then(@"system should display teammembers page")]
     //     public async Task ThenSystemShouldDisplayTeammembersPage()
     //     {
     //          await _userPage.verifySetUpteamPage();
     //     }

     //     [Then(@"user clicks on Add Team Member button")]
     //     public async Task ThenUserClicksOnAddTeamMemberButton()
     //     {
     //          await _userPage.clickOnAddTeamMember();
     //     }

     //     [Then(@"user fill all the mandatory fields")]
     //     public async Task ThenUserFillAllTheMandatoryFields()
     //     {
     //          await _userPage.fillMandatoryFieldsTeam();
     //     }

     //     [Then(@"user click on Save and close button")]
     //     public async Task ThenUserClickOnSaveAndCloseButton()
     //     {
     //          await _userPage.clickOnSaveAndClose();
     //     }

     //     [Then(@"user enters the created account name")]
     //     public async Task ThenUserEntersTheCreatedAccountName()
     //     {
     //          await _userPage.enterAccountname();
     //     }

     //     [Then(@"system should display the account details")]
     //     public async Task ThenSystemShouldDisplayTheAccountDetails()
     //     {
     //          await _userPage.verifyAccountSearch();
     //     }
     //     [Then(@"user clicks on edit button of first row")]
     //     public async Task userclicksoneditbuttonoffirsrow()
     //     {
     //         await _userPage.clickOnFirstRow();
     //     }
     //     [Then(@"user edits the first name of user")]
     //     public async Task usereditsthefirstnameofuser()
     //     {
     //         await _userPage.updateFirstName();
     //     }
     //     [Then(@"user search the account using last name")]
     //     public async Task usersearchtheaccountusinglastname()
     //     {
     //         await _userPage.searchAccount();
     //     }
     //     [Then(@"user verify the updated changes")]
     //     public async Task userverifytheupdatedchanges()
     //     {
     //         await _userPage.verifyUpdate();
     //     }
//          [Then(@"user click on delete button")]
//          public async Task userclickondeletebutton()
//          {
//              await _userPage.clickOnDelete();
//              await _userPage.clickOnDeletePoup();
//          }
//          [Then(@"user clicks on close button")]
//          public async Task userclickonclosebutton()
//          {
//              await _userPage.clickOnClose();
             
//          }
//          [Then(@"user verify the account is deleted")]
//          public async Task userverifytheaccountisdeleted()
//          {
//              Assert.IsFalse(await _userPage.verifyAccountDelete());
             
//          }
//     }
// }
