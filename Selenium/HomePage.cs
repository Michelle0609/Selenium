using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium
{
    public class HomePage: BasePageClass
    {
        string travelElement = "//p[text() = 'Heading overseas?']/ancestor::div/p[text() = 'Tell me more']";
        public HomePage(IWebDriver driver_) :base(driver_)
        {
            
        }

        public void NavigateToOverseaPage()
        {
            NavigateTo(By.XPath(travelElement));
        }

        void NavigateTo(By locator)
        {
            Helper.GetElement(driver,locator).Click();
        }
    }
}
