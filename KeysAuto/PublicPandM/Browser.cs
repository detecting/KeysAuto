using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

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
            PublicPandM.PropertiesAndMethods._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            PublicPandM.PropertiesAndMethods._driver.Navigate().GoToUrl(PublicPandM.PropertiesAndMethods.url);
            PublicPandM.PropertiesAndMethods._driver.Manage().Window.Maximize();
        }
    }
}