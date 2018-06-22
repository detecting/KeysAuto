using System;
using OpenQA.Selenium.Chrome;

namespace KeysAuto.PublicPandM
{
    /// <summary>
    /// initial browser
    /// </summary>
    class Browser
    {

        public Browser()
        {
            PublicPandM.PropertiesAndMethods._driver = new ChromeDriver();
            //wait for page for 8s
            PublicPandM.PropertiesAndMethods._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PublicPandM.PropertiesAndMethods._driver.Navigate().GoToUrl(PublicPandM.PropertiesAndMethods.url);
            PublicPandM.PropertiesAndMethods._driver.Manage().Window.Maximize();
        }
    }
}