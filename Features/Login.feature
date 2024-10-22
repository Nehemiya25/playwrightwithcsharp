
Feature: Login 

  @Login @smoke
  Scenario: Logging into website using valid credentials
    Given user navigate to the login page
    When user enter valid credentials
    Then user should be logged in successfully

    