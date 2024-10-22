Feature: User Management 

  @createUser @smoke
  Scenario: Create user
    Given user navigate to the login page
    When user enter valid credentials
    Then user should be logged in successfully
    And user clicks on setup tab
    Then system should display account setup page
    And user clicks on manage team members button 
    Then system should display teammembers page
    And user clicks on Add Team Member button
    And user fill all the mandatory fields 
    And user click on Save and close button
    And user enters the created account name
    Then system should display the account details

    @editUser @smoke
  Scenario: edit user
    Given user navigate to the login page
    When user enter valid credentials
    Then user should be logged in successfully
    And user clicks on setup tab
    Then system should display account setup page
    And user clicks on manage team members button
    And user clicks on edit button of first row
    And user edits the first name of user
    And user click on Save and close button
    And user search the account using last name
    And user verify the updated changes

    @deleteUser @smoke
  Scenario: delete user
    Given user navigate to the login page
    When user enter valid credentials
    Then user should be logged in successfully
    And user clicks on setup tab
    Then system should display account setup page
    And user clicks on manage team members button
    And user clicks on edit button of first row
    And user click on delete button
    And user clicks on close button
    And user search the account using last name
    And user verify the account is deleted