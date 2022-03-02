using PlanYourJourney.Hooks;
using PlanYourJourney.PageObjects;
using PlanYourJourney.TestData;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace PlanYourJourney.StepDefinitions
{
    [Binding]
    public class JourneyPlannerSteps
    {
        [Given(@"User navigates to the Journey Planner widget")]
        public void UserNavigatesToTheJourneyPlannerWidgett()
        {
            try
            {
                DriverClass.StartTest(TestConfig.tflUrl);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                Thread.Sleep(2000);
                if (loginPage.acceptCookies != null)
                {
                    loginPage.acceptCookies.Click();
                    loginPage.done.Click();
                }         
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not load the application : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }


        [When(@"User enters valid locations (.*) and (.*) into the widget")]
        public void UserEntersValidLocationsIntoTheWidget(string from, string to)
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                CustomBaseClass.EnterText(loginPage.inputFrom, from);
                loginPage.inputFrom.SendKeys(Keys.ArrowDown);
                loginPage.inputFrom.SendKeys(Keys.Enter);
                CustomBaseClass.EnterText(loginPage.inputTo, to);
                loginPage.inputTo.SendKeys(Keys.Enter);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }
            
        }


        [Then(@"User should see the journey results")]
        public void UserShouldSeeTheJourneyResults()
        {
            try
            {
                CustomBaseClass.Thinktime(5);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.journeyResultSummary);
                AssertClass.AssertElementIsPresent(loginPage.publicTransportBox);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }

        }

        [When(@"User enters invalid locations (.*) and (.*) into the widget")]
        public void UserEntersInValidLocationsIntoTheWidget(string from, string to)
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                CustomBaseClass.EnterText(loginPage.inputFrom, from);
                CustomBaseClass.EnterText(loginPage.inputTo, to);
                loginPage.inputTo.SendKeys(Keys.Enter);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }

        }

        [Then(@"User should not see the journey results")]
        public void UserShouldNotSeeTheJourneyResults()
        {
            try
            {
                CustomBaseClass.Thinktime(5);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.invalidLocationMessage);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }

        }

        [When(@"User doesnot enter any locations to the widget")]
        public void UserDoesnotEnterAnyLocationsToTheWidget()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                loginPage.planJourneyButton.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"User should see error message")]
        public void UserShouldSeeErrorMessage()
        {
            try
            {
                CustomBaseClass.Thinktime(5);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.errorMessage);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [When(@"User clicks on Recents tab")]
        public void UserClicksOnRecentsTab()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                loginPage.recent.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"User should see the list of recently planned journeys")]
        public void UserShouldSeeTheListOfRecentlyPlannedJourneys()
        {
            try
            {
                CustomBaseClass.Thinktime(5);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.listOfJourneys);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"User should be able to edit the journey")]
        public void UserShouldBeAbleToEditTheJourney()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                loginPage.editJourney.Click();
                loginPage.arriving.Click();
                var selectElement = new SelectElement(loginPage.dateDropDown);
                selectElement.SelectByIndex(2);
                loginPage.updateJourney.Click();
                AssertClass.IsElementPresent(loginPage.updateSuccess);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: ", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }




    }
}
