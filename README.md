# Test Plan : The Challenging DOM web page
# Introduction
### This document describes how the test on the Challenging DOM web page are to be planned

# Scope
1. Functional tests on web page located here:
 https://the-internet.herokuapp.com/challenging_dom
2. The latest chrome browser version is used and tests are running on it. Other browsers out of scope.
3. Simple functional test only - excludes scalability, resilience tests.

# Test Strategy
 The test strategy is to check & validate on various parts of the web page, including elements such as title, buttons, table elements and links.

# Environment Requirements:
### Automation Framework: xUnit Framework
1. It's an automation framework using xUnit and wrote in C# language to run.
2. Selenium and the latest version of Chrome browser with the corresponding chromedriver application. 
3. Good internet speed is required to run the tests.

# Test Schedule
### All tests to be performed anytime with the all upto date packages.

# The Challenging Dom web page:
## It is used to automate the Challenging Dom page.

# API Tool:
1. Selenium is used to do the browser automation
2. Fluent Assertion is used to make test better and clear.

# Test Cases
## UITest folder has the automation test class file
> ChallengingDomTest.cs file has all tests
1. Check the Page Title
2. Validate various buttons
3. Validate table elements including header and columns values
4. Validte the edit/delete button in the table
5. Validate the Answer values 

# Resources and Responsibilities
Pankaj Kumar Shee is the creater of this documents and automation tests.

# Deliverables
1. Test Plan
2. Test Code

# Tools:
1. MS Visual Studio
2. Selenium C# xUnit test framework
3. Chrome browser and chromedriver executable

# Documentation
 All documentation is provided in-line with the test code

# Approvals
 Tests and documentation will be reviewed....

# NuGet Packages:
## It's handling all required libraries to run the automation

# CI/CD Pipeline: Azure
1. The test cases are run in the Azure Pipeline and provided a test results with test result percentages %
2. It too provides the passed and failed tests.
3. Example of test results

![Screenshot 2023-02-06 at 4 09 11 AM](https://user-images.githubusercontent.com/44091458/216882001-f1aceef8-834c-4613-a74d-83fb5e296f14.png)
