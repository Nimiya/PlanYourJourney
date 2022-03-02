using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanYourJourney.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement acceptCookies => driver.FindElement(By.XPath("//strong[contains(text(),'Accept all cookies')]"));
        public IWebElement done => driver.FindElement(By.XPath("//strong[contains(text(),'Done')]"));
        public IWebElement inputFrom => driver.FindElement(By.XPath("//input[contains(@id,'InputFrom')]"));
        public IWebElement inputTo => driver.FindElement(By.XPath("//input[contains(@id,'InputTo')]"));
        public IWebElement planJourneyButton => driver.FindElement(By.XPath("//input[contains(@id,'plan-journey-button')]"));
        public IWebElement journeyResultSummary => driver.FindElement(By.XPath("//div[contains(@class,'journey-result-summary')]"));
        public IWebElement invalidLocationMessage => driver.FindElement(By.XPath("//span[contains(text(),'We found more than one location matching')]"));
        public IWebElement publicTransportBox => driver.FindElement(By.XPath("//div[contains(@class,'publictransport-box')]"));
        public IWebElement errorMessage => driver.FindElement(By.XPath("//span[contains(text(),'field is required')]"));
        public IWebElement recent => driver.FindElement(By.XPath("(//a[contains(text(),'Recents')])[1]"));
        public IWebElement listOfJourneys => driver.FindElement(By.XPath("//div[contains(@id,'jp-recent-content-home-')]"));
        public IWebElement editJourney => driver.FindElement(By.XPath("//span[contains(text(),'Edit journey')]"));
        public IWebElement dateDropDown => driver.FindElement(By.XPath("//select[contains(@id,'Date')]"));
        public IWebElement arriving => driver.FindElement(By.XPath("//label[contains(text(),'Arriving')]"));
        public IWebElement updateJourney => driver.FindElement(By.XPath("(//input[contains(@value,'Update journey')])[1]"));
        public IWebElement updateSuccess => driver.FindElement(By.XPath("//span[contains(text(),'Arriving')]"));

    }
}
