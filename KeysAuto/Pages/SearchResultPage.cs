using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace KeysAuto.Pages
{
    class SearchResultPage
    {
        public SearchResultPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]")]
        IWebElement DdSortBy { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/section[1]/div[1]/div[1]/div[3]/div[1]")]
        IWebElement DivListResult { get; set; }

        public string SortByTimeAndCheckResults(string latest, string inputSearching)
        {
            DdSortBy.Click();
            IWebElement lists =
                new WebDriverWait(PublicPandM.PropertiesAndMethods._driver, TimeSpan.FromSeconds(2)).Until(
                    ExpectedConditions.ElementExists(By.XPath(
                        "/html[1]/body[1]/div[2]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]")));
            var dataLists = lists.FindElements(By.TagName("div"));
            foreach (var item in dataLists)
            {
                if (item.Text.Contains(latest))
                {
                    item.Click();
                    goto done;
                }
            }
            done:
            while (!PublicPandM.PropertiesAndMethods._driver.Url.Contains("Latest"))
            {
                Thread.Sleep(200);
            }

            var dataDivs = DivListResult.FindElements(By.TagName("h3"));
            foreach (var item in dataDivs)
            {
                if (item.Text == inputSearching)
                {
                    return item.Text;
                }
            }
            return null;
        }
    }
}