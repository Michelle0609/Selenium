using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Selenium
{
    public class NetBankPage: BasePageClass
    {
        string userName = "txtMyClientNumber_field";
        string password = "txtMyPassword_field";
        public NetBankPage(IWebDriver driver_) :base(driver_)
        {
           
        }

        public bool FindUserName()
        {
           return FindElement(By.Id(userName));
        }
        public bool FindPassword()
        {
            return FindElement(By.Id(password));
        }

        bool FindElement(By locator)
        {
            try
            {
                Helper.GetElement(driver, locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }
        
    }
}
