using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KeysAuto.Pages
{
    class PropertyOwnersPage
    {
        public PropertyOwnersPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[2]/div[1]/div[1]/input")]
        public IWebElement InputPropertyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[2]/div[2]/div")]
        public IWebElement DpdPropertyType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"autocomplete\"]")]
        public IWebElement InputSearchAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[3]/div[2]/div[1]/textarea")]
        public IWebElement TextareaDescription { get; set; }

        [FindsBy(How = How.Id, Using = "street_number")]
        public IWebElement InputNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"route\"]")]
        public IWebElement InputStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement PropertyType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[2]/div[2]/div")]
        public IWebElement PropertyType { get; set; }
    }
}