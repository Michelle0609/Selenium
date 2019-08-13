using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium
{
    public class OverseasPage:BasePageClass
    {
      
        string subTopic = "//h2";
        string netBankLink = "//P[contains(text(),'Log on to')]/a[text()='NetBank']";

        public OverseasPage(IWebDriver driver_) :base(driver_)
        {

        }
        public List<string> GetSubTopic()
        {
            List<string> elementTexts = Helper.GetElements(driver,(By.XPath(subTopic))).Select(i => i.Text).ToList();
            return elementTexts;
        }
        public void NavigateToNetBank()
        {
            Helper.GetElement(driver,By.XPath(netBankLink)).Click();
        }


    }
}
