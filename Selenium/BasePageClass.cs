using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class BasePageClass
    {
        public IWebDriver driver;
        public BasePageClass(IWebDriver driver_)
        {
            this.driver = driver_;
        }

    }
}
