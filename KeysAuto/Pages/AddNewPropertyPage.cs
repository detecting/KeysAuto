using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KeysAuto.Pages
{
    class AddNewPropertyPage
    {
        private string searchAdd = "20 Canberra Ave, Lynfield, Auckland, New Zealand";

        public AddNewPropertyPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[2]/div[1]/div[1]/input")]
        IWebElement InputPropertyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[2]/div[2]/div")]
        IWebElement DpdPropertyType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"autocomplete\"]")]
        IWebElement InputSearchAddress { get; set; }
        //
        //        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[3]/div[2]/div[1]/textarea")]
        //        public IWebElement TextareaDescription { get; set; }
        //
        //        [FindsBy(How = How.Id, Using = "street_number")]
        //        public IWebElement InputNumber { get; set; }
        //
        //        [FindsBy(How = How.XPath, Using = "//*[@id=\"route\"]")]
        //        public IWebElement InputStreet { get; set; }


        public void enterContextIntoSearchAddress()
        {
            //clean the InputSearchAddress input
            InputSearchAddress.Clear();
            //full the InputSearchAddress
            InputSearchAddress.SendKeys(searchAdd);
            Thread.Sleep(1000);
            //press down key
            //Actions actions = new Actions(PublicPandM.PropertiesAndMethods._driver);
            InputSearchAddress.SendKeys(Keys.ArrowDown);
            InputSearchAddress.SendKeys(Keys.Enter);
        }
    }
}