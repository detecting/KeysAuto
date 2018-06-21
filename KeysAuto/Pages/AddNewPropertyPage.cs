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

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[2]/div[1]/div[1]/input[1]")]
        IWebElement InputPropertyName { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[2]/div[2]/div[1]")]
//        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[2]/div[2]/div[1]/div[2]/div[3]")]
        IWebElement DpdPropertyType { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[3]/div[1]/div[1]/input[1]")]
        IWebElement InputSearchAddress { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[3]/div[2]/div[1]/textarea[1]")]
        IWebElement TextDescription { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[4]/div[1]/div[1]/div[1]/input[1]")]
        IWebElement InputTargetRent { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[4]/div[1]/div[2]/div[1]")]
        IWebElement DdpRentType { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[5]/div[1]/div[1]/input[1]")]
        IWebElement InputLandArea { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[5]/div[2]/div[1]/input[1]")]
        IWebElement InputFloorArea { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[6]/div[1]/div[1]/input[1]")]
        IWebElement InputBedrooms { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[6]/div[2]/div[1]/input[1]")]
        IWebElement InputBathrooms { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[7]/div[1]/div[1]/input[1]")]
        IWebElement InputCarparks { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[7]/div[2]/div[1]/input[1]")]
        IWebElement InputYearBuilt { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[8]/div[1]/input[1]")]
        IWebElement CBOwnerOccupied { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[1]/div[10]/div[1]/button[1]")]
        IWebElement BtnNext { get; set; }

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

        public void LandArea(string landArea)
        {
            InputLandArea.Clear();
            InputLandArea.SendKeys(landArea);
        }

        public void FloorArea(string floorArea)
        {
            InputFloorArea.Clear();
            InputFloorArea.SendKeys(floorArea);
        }

        public void Bedrooms(string bedrooms)
        {
            InputBedrooms.Clear();
            InputBedrooms.SendKeys(bedrooms);
        }

        public void Bathrooms(string bathrooms)
        {
            InputBathrooms.Clear();
            InputBathrooms.SendKeys(bathrooms);
        }

        public void Carparks(string carparks)
        {
            InputCarparks.Clear();
            InputCarparks.SendKeys(carparks);
        }

        public void YearBuilt(string yearBuilt)
        {
            InputYearBuilt.Clear();
            InputYearBuilt.SendKeys(yearBuilt);
        }

        public void OwnerOccupied()
        {
            CBOwnerOccupied.Click();
        }

        public FinancedetailsPage Next()
        {
            if (BtnNext.Displayed && BtnNext.Enabled)
            {
                BtnNext.Click();
                return new FinancedetailsPage();
            }

            return null;
        }
    }
}