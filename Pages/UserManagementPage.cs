using System.Text;
using Microsoft.Playwright;
using PlaywrightTests.pageObjects;
namespace PlaywrightTests.Pages
{
    public class UserManagementPage
    {
        private readonly IPage _page = null!;
        private readonly AddUSerPage _adduserpage = new AddUSerPage();
        private readonly DeleteUserPage _deleteUserPage = new DeleteUserPage();
        private readonly UserManagement _userPAge = new UserManagement();
        
        string fname = null!;
        string lastName = null!;
        public UserManagementPage(IPage page)
        {
            _page = page;
        }
           public async Task clickOnManageTeam()
        {
             await _page.ClickAsync(_userPAge.manageTeamButton);
        }

           public async Task clickOnSetupTab()
        {
             await _page.ClickAsync(_userPAge.setUptab);
        }

           public async Task verifySetupPage()
        {
            await _page.IsVisibleAsync(_userPAge.accountSetupHeader);
        }

           public async Task verifySetUpteamPage()
        {
             await _page.IsVisibleAsync(_userPAge.setUpTeamHeader);
             
        }

        public async Task clickOnSaveAndClose()
        {
            await _page.ClickAsync(_userPAge.saveAndCloseButton);
        }

        public async Task enterAccountname()
        {
            await _page.FillAsync(_userPAge.accountNameInput, fname);
        }

        public async Task fillMandatoryFieldsTeam()
        {
         await _page.SelectOptionAsync(_adduserpage.memberRoleDropDown,_adduserpage.memberRoleValue); 
         fname = GenerateRandomString(6);
         await _page.FillAsync(_adduserpage.firstNameInput, fname);
         string lname = GenerateRandomString(6);
         await _page.FillAsync(_adduserpage.lastNameInput, lname);
         string uname = GenerateRandomString(6);
         await _page.FillAsync(_adduserpage.userNameInput, uname);
         string gmail = GenerateRandomString(9);
         await _page.FillAsync(_adduserpage.emailInput, gmail + "@gmail.com");
         string pass = GenerateRandomPassword(11);
         await _page.FillAsync(_adduserpage.passwordInput, pass);
         await _page.FillAsync(_adduserpage.confirmPasswordInput, pass);
        }

        public async Task verifyAccountSearch()
        {
            await _page.IsVisibleAsync(_userPAge.firstRow.Replace("name", fname));
        }
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                stringBuilder.Append(chars[index]);
            }

            return stringBuilder.ToString();
        }
        static string GenerateRandomPassword(int length)
        {
            const string capChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string nums = "1234567890";
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < length / 3 + 1; i++)
            {
                int index = random.Next(chars.Length);
                int index2 = random.Next(nums.Length);
                int index3 = random.Next(capChars.Length);
                stringBuilder.Append(chars[index]);
                stringBuilder.Append(nums[index2]);
                stringBuilder.Append(capChars[index3]);
            }

            return stringBuilder.ToString();
        }

        public async Task  clickOnFirstRow()
        {
            lastName =  await _page.TextContentAsync(_userPAge.firstAccountName);
            lastName = lastName.Split(",")[1];
            await _page.ClickAsync(_userPAge.editButton);
        }

        public async Task  updateFirstName()
        {
            fname = GenerateRandomString(6);
            await _page.FillAsync(_adduserpage.firstNameInput, fname);
            
        }

        public async Task  searchAccount()
        {
            await _page.FillAsync(_userPAge.accountNameInput, lastName);
            
        }

        public async Task  verifyUpdate()
        {
            await _page.IsVisibleAsync(_userPAge.firstRow.Replace("name", fname));
        }

        public async Task  clickOnDelete()
        {
            await _page.ClickAsync(_deleteUserPage.deleteButton);
            
        }

        public async Task  clickOnDeletePoup()
        {
             await _page.ClickAsync(_deleteUserPage.deletePopUP);
        }

        public async Task<bool>  verifyAccountDelete()
        {
            return await _page.IsVisibleAsync(_userPAge.firstRow.Replace("name", lastName));
        }

         public async Task clickOnClose()
        {   try{
             await _page.ClickAsync(_userPAge.closeButton);
            }
            catch(Exception e){
               await _page.ClickAsync(_userPAge.saveAndCloseButton);
            }
        }

         public async Task clickOnAddTeamMember()
        {
           await _page.ClickAsync(_adduserpage.addTeamMemberButton);
        }
    }
}