using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium
{
    [TestClass]
    public class BaseClass
    {
        public static IWebDriver driver;

        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(50);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
             
        }


        [AssemblyCleanup]
        public static void TearDown()
        {
            if (driver != null)
            {
               driver.Close();
               driver.Quit();
            }
        }

    }
}
