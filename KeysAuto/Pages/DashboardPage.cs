﻿using System;
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
        IWebElement ListOwners { get; set; }

        ///html/body/div[1]/div/div[2]/div[1]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        IWebElement ClickOwner { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/a[2]")]
        IWebElement LinkPropertiesForRent { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/a[3]")]
        IWebElement LinkMarketPlace { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/input[1]")]
        IWebElement InputSearch { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/i[1]")]
        IWebElement BtnSearch { get; set; }

        public void Search(string inputSearing)
        {
            InputSearch.Clear();
            InputSearch.SendKeys(inputSearing);
            BtnSearch.Click();
        }
        public PropertyOwnersPage SelectPropertiesUnderOwner(string properies)
        {
            IWebElement toBeSelect = null;
            //show the page
            BtnSkip.Click();
            Thread.Sleep(1000);
            ClickOwner.Click();
            //get the list of Owner
            var lists = ListOwners.FindElements(By.TagName("a"));
            foreach (var item in lists)
            {
                //delete the space and \n\r of the string, if cant
                if (item.GetAttribute("text").Replace(System.Environment.NewLine, string.Empty).Trim() == properies)
                {
                    toBeSelect = item;
                }
            }

            toBeSelect.Click();
            return new PropertyOwnersPage();
        }
    }
}