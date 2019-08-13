using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Selenium
{
    [Binding]
    public sealed class CABStepDefinition: BaseClass
    {
        //should be moved to app.config file
        string Url = "https://www.commbank.com.au/";
        HomePage homePage;
        NetBankPage netBankPage;
        OverseasPage overseasPage;
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"I click link to go to oversea page")]
        public void WhenIClickLinkToGoToOverseaPage()
        {
            homePage = new HomePage(driver);
            homePage.NavigateToOverseaPage();
        }

        [Then(@"all of the sub topic shoule be present as expected")]
        public void ThenAllOfTheSubTopicShouleBePresentAsExpected(Table table)
        {
            overseasPage = new OverseasPage(driver);
            var subTopics = overseasPage.GetSubTopic();
            foreach (var row in table.Rows)
            {
                string expectedSubTopic = row["Topic"];
                if (!subTopics.Contains(expectedSubTopic))
                {
                    Assert.Fail($"Sub Topic '{expectedSubTopic} doesn't exist on the overseas page" );
                }
            }      
            
        }
        [When(@"I click netbank logon link")]
        public void WhenIClickNetbankLogonLink()
        {
            overseasPage.NavigateToNetBank();
        }

        [Then(@"Page '(.*)' should be opened with username and password fields")]
        public void ThenPageShouldBeOpenedWithUsernameAndPasswordFields(string title)
        {
            if(driver.Title.Contains(title))
            {
                if (!netBankPage.FindUserName())
                {
                    Assert.Fail("User name field doesn't exist on the page");
                }
                if (!netBankPage.FindPassword())
                {
                    Assert.Fail($"Password filed doesn't existon the page");
                }
            }
            else
            {
                Assert.Fail($"{title} page is not opened");
            }
        }


    }
}
