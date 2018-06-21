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
    class AddNewPropertyPage
    {
        public AddNewPropertyPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[2]/div[1]/div[1]/input")]
        IWebElement InputPropertyName { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[2]/div[2]/div[1]")]
//        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[2]/div[2]/div[1]/div[2]/div[3]")]
        IWebElement DpdPropertyType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"autocomplete\"]")]
        IWebElement InputSearchAddress { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[3]/div[2]/div[1]/textarea[1]")]
        public IWebElement TextDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[4]/div/div[1]/div[1]/input")]
        IWebElement InputTargetRent { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[4]/div/div[2]/div")]
        IWebElement DdpRentType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[5]/div[1]/div/input")]
        IWebElement InputLandArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[5]/div[2]/div/input")]
        IWebElement InputFloorArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[6]/div[1]/div[1]/input")]
        IWebElement InputBedrooms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[6]/div[2]/div[1]/input")]
        IWebElement InputBathrooms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[7]/div[1]/div[1]/input")]
        IWebElement InputCarparks { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"property - details\"]/div[7]/div[2]/div[1]/input")]
        IWebElement InputYearBuilt { get; set; }

        public void PropertyName(string propertyName)
        {
            InputPropertyName.Clear();
            InputPropertyName.SendKeys(propertyName);
        }

        public void PropertyType(string propertyType)
        {
            //use js to execute on invisible element**************************
            //            IJavaScriptExecutor js = (IJavaScriptExecutor) PublicPandM.PropertiesAndMethods._driver;
            //            js.ExecuteScript("arguments[0].click()", DpdPropertyType);

            //click the PropertyType
            DpdPropertyType.Click();
            //wait fot the lsit to show up
            IWebElement listPropertyType =
                new WebDriverWait(PublicPandM.PropertiesAndMethods._driver, TimeSpan.FromSeconds(5)).Until(
                    ExpectedConditions.ElementExists(
                        By.XPath(
                            "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[2]/div[2]/div[1]/div[2]")));
            var lists = listPropertyType.FindElements(By.TagName("div"));
            foreach (var item in lists)
            {
                if (item.Text == propertyType)
                {
                    item.Click();
                }
            }
        }

        public void SearchAddress(string searchAddress)
        {
            //clean the InputSearchAddress input
            InputSearchAddress.Clear();
            //full the InputSearchAddress
            InputSearchAddress.SendKeys(searchAddress);
            Thread.Sleep(1000);
            //press down key
            InputSearchAddress.SendKeys(Keys.ArrowDown);
            //press the enter key
            InputSearchAddress.SendKeys(Keys.Enter);
        }

        public void Description(string description)
        {
            TextDescription.Clear();
            TextDescription.SendKeys(description);
        }

        public void TargetRent(string targetRent)
        {
            InputTargetRent.Clear();
            InputTargetRent.SendKeys(targetRent);
        }

        public void RentType(string rentType)
        {
            DdpRentType.Click();
            IWebElement listsDdpRentType =
                new WebDriverWait(PublicPandM.PropertiesAndMethods._driver, TimeSpan.FromSeconds(5)).Until(
                    ExpectedConditions.ElementExists(By.XPath(
                        "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[4]/div[1]/div[2]/div[1]/div[2]")));
            var lists = listsDdpRentType.FindElements(By.TagName("div"));
            foreach (var item in lists)
            {
                if (item.Text == rentType)
                {
                    item.Click();
                }
            }
        }

        public void LandArea(int landArea)
        {
        }

        public void FloorArea(int floorArea)
        {
        }

        public void Bedrooms(int bedrooms)
        {
        }

        public void Bathrooms(int bathrooms)
        {
        }

        public void Carparks(int carparks)
        {
        }

        public void YearBuilt(int yearBuilt)
        {
        }
    }
}