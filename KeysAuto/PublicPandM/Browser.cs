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
        public static IWebDriver Driver { get; set; }
        private IWindow window = Driver.Manage().Window;
        public void BrowserInitial()
        {
            //open chrome
            PublicPandM.PropertiesAndMethods._driver=new ChromeDriver();
            Driver = PublicPandM.PropertiesAndMethods._driver;
            //wait for page for 8s
            Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(8);
            Driver.Navigate().GoToUrl(PublicPandM.PropertiesAndMethods.url);
            window.Maximize();
        }
    }
}
