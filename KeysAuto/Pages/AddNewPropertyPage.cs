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

        }

        public void TargetRent(string targetRent)
        {
        }

        public void RentType(string rentType)
        {
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

        public void SearchAddress()
        {
            //clean the InputSearchAddress input
            InputSearchAddress.Clear();
            //full the InputSearchAddress
            InputSearchAddress.SendKeys(searchAdd);
            Thread.Sleep(1000);
            //press down key
            InputSearchAddress.SendKeys(Keys.ArrowDown);
            //press the enter key
            InputSearchAddress.SendKeys(Keys.Enter);
        }
    }
}