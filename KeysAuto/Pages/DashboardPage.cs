using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace KeysAuto.Pages
{
    class DashboardPage : BasePage
    {
//        private string properies = "Properties";

        public DashboardPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        //        /html/body/div[5]/div/div[5]/a[1]
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        public IWebElement BtnSkip { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/a[1]")]
        IWebElement LinkDashboard { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div")]
        IWebElement LinkOwners { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/a[2]")]
        IWebElement LinkPropertiesForRent { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/a[3]")]
        IWebElement LinkMarketPlace { get; set; }


        [FindsBy(How = How.XPath,
            Using = "//*[@id=\"main - content\"]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[1]/h5")]
        IWebElement AMyProperties { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//*[@id=\"main - content\"]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[2]/h5")]
        IWebElement AMyTenants { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//*[@id=\"main - content\"]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[3]")]
        IWebElement AFinanceDetails { get; set; }

        public PropertyOwnersPage SelectPropertiesUnderOwner(string properies)
        {
            //show the page
            BtnSkip.Click();
            Thread.Sleep(1500);
            //get the list of Owner
            var lists = LinkOwners.FindElements(By.TagName("a"));
            foreach (var item in lists)
            {
                Console.WriteLine(item.Text);


                string a = item.GetAttribute("innerHTML");
                Console.WriteLine(a);
                if (a == properies)
                {
                    item.Click();
                }
            }

            return new PropertyOwnersPage();
        }
    }
}