namespace PlaywrightTests.pageObjects
{
    public class UserManagement{
        
        public    string manageTeamButton = "//h3[text()='Manage Team Members']/parent::div/descendant::a[text()=' Manage ']";
        public    string setUptab = "//a[text()='Setup']";
        public    string accountSetupHeader = "//h1[text()='Account Setup']";
        public    string setUpTeamHeader = "//h2[text()='Team Members']";
        public    string saveAndCloseButton = "//span[text()=' Save and Close ']";
        public    string accountNameInput = "//input[@placeholder='Search team members']";
        
        public    string closeButton = "//span[text()=' Close ']";
        public    string firstRow = "//tbody/tr[1]/td[contains(text(),'name')]";
        public string firstAccountName = "//tr[1]/td[1]";
        public string editButton = "//tr[1]/td[5]/a[2]";
        
    }
}