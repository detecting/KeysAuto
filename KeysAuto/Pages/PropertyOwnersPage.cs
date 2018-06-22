using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KeysAuto.Pages
{
    class PropertyOwnersPage
    {
        public PropertyOwnersPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver,this);
        }

        [FindsBy(How = How.XPath,Using = "//html//div[@data-bind='visible : MainView']/div/div[@class='ui grid']//a[2]")]
        IWebElement BtnAddNewProperty { get; set; }

        public AddNewPropertyPage ClickAddNewProperty()
        {
            BtnAddNewProperty.Click();
            return new AddNewPropertyPage();
        }
    }
}