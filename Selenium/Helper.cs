using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class Helper
    {
        public static bool IsElemetPresent(IWebDriver driver,By locator)
        {
            try
            {
                return driver.FindElements(locator).Count>= 1;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static IWebElement GetElement(IWebDriver driver,By locator)
        {
            if (IsElemetPresent(driver,locator))
                return driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        public static List<IWebElement> GetElements(IWebDriver driver, By locator)
        {
            if (IsElemetPresent(driver, locator))
                return driver.FindElements(locator).ToList();
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }
    }
}
