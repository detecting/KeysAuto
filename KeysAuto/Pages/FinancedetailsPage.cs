using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace KeysAuto.Pages
{
    class FinancedetailsPage
    {
        public FinancedetailsPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/h2[1]")]
        IWebElement TextFinancedetails { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[1]/div[1]/input[1]")]
        IWebElement InputPurchasePrice { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[2]/div[1]/input[1]")]
        IWebElement InputMortgage { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[3]/div[1]/input[1]")]
        IWebElement InputHomeValue { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[4]/div[1]")]
        IWebElement DdlHomeValueType { get; set; }

        [FindsBy(How = How.XPath,
            Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[4]/div[1]/div[2]")]
        IWebElement ListHomeValueType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[8]/button[2]")]
        IWebElement BtnSave { get; set; }


        public string Financedetails()
        {
            return TextFinancedetails.Text;
        }

        public void PurchasePrice(string price)
        {
            InputPurchasePrice.Clear();
            InputPurchasePrice.SendKeys(price);
        }

        public void Mortgage(string mortgage)
        {
            InputMortgage.Clear();
            InputMortgage.SendKeys(mortgage);
        }

        public void HomeValue(string value)
        {
            InputHomeValue.Click();
            InputHomeValue.SendKeys(value);
        }

        public void HomeValueType(string value)
        {
            DdlHomeValueType.Click();
            new WebDriverWait(PublicPandM.PropertiesAndMethods._driver, TimeSpan.FromSeconds(3)).Until(
                ExpectedConditions.ElementExists(
                    By.XPath("/html[1]/body[1]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[4]/div[1]/div[2]")));
            var lists = ListHomeValueType.FindElements(By.TagName("div"));
            foreach (var item in lists)
            {
                if (item.Text == value)
                {
                    item.Click();
                }
            }
        }

        public MyPropertiesPage Save()
        {
            if (BtnSave.Displayed && BtnSave.Enabled)
            {
                BtnSave.Click();
                //waiting for the new page to loaded.
                new WebDriverWait(PublicPandM.PropertiesAndMethods._driver, TimeSpan.FromSeconds(10)).Until(
                    ExpectedConditions.ElementExists(
                        By.XPath("/html[1]/body[1]/div[2]/section[1]/div[1]/div[1]/div[3]/div[1]")));
                return new MyPropertiesPage();
            }

            return null;
        }
    }
}