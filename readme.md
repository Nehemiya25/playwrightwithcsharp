Description:
  This repo contains the automation using playwright with csharp.
  The test cases are written for Rethink web application which consists valid login, add user, edit user, delete user
  The test cases can be red from Feature folder, which are written in Gherkin language


Prerequisites:
  Add the NuGet packages
    dotnet add package Microsoft.Playwright
    dotnet add package SpecFlow
    dotnet add package SpecFlow.NUnit
    dotnet add package SpecFlow.Tools.MsBuild.Generation
  Install playwright
    dotnet playwright install
  Commands to run tests:
    dotnet test - to run all available test cases
    dotnet test --filter "Category=tagName" - to run testcases with specific tagname
    Run command: 
            dotnet test --filter "Category=smoke" to execute all test cases
            tagName = login, to execute valid login testcase
            tagName = addUser, to execute  add user testcase
            tagName = editUser, to execute  edit User  testcase
            tagName = delte user, to execute  delete user testcase
            
