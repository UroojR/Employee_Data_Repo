using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowTest.Steps
{
    [Binding]
    public class assignment
    {

        ChromeDriver driver = new ChromeDriver();
        [Given(@"I navigate to my main page")]
        public void GivenINavigateToMyMainPage()
        {
            driver.Navigate().GoToUrl("http://localhost:9105/Home/Index");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"I click on Create Add New Employee button")]
        public void WhenIClickOnCreateNewEmployeeLink()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/button")).Click();
            Thread.Sleep(2000);
        }

        [When(@"I enter valid Employee Information")]
        public void WhenIEnterValidEmployeeInformation()
        {
            driver.FindElement(By.XPath("//*[@id='empID']")).SendKeys("123456");
            driver.FindElement(By.XPath("//*[@id='empName']")).SendKeys("Urooj");
            driver.FindElement(By.XPath("//*[@id='department']")).SendKeys("QA");
            driver.FindElement(By.XPath("//*[@id='btnAdd']")).Click();
            Thread.Sleep(2000);
        }
        [Then(@"I should see employee in the list")]
        public void ThenIShouldSeeEmployeeInTheList()
        {
            IWebElement label = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/table/tbody/tr/td[1]"));
            String labelText = label.Text;
            if (labelText == "123456")
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Assert.Fail();
            }
        }

        [When(@"I click on Delete button")]
        public void WhenIClickOnDeleteButton()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/table/tbody/tr/td[4]/a")).Click();
        }

        [Then(@"I should be on the main page again")]
        public void ThenIShouldBeOnTheMainPageAgain()
        {
            IWebElement newEmpBtn = driver.FindElement(By.XPath("/html/body/div[2]"));
            if (newEmpBtn != null)
            {
                Console.WriteLine("Passed");
            } else
            {
                Assert.Fail();
            }
        }

    }
}
