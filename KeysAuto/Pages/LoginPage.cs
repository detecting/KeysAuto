using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KeysAuto.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage()
        {
            PageFactory.InitElements(PublicPandM.PropertiesAndMethods._driver, this);
        }

        [FindsBy(How = How.Id, Using = "UserName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sign_in\"]/div[1]/div[3]/div/label")]
        IWebElement lableRememberMe { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sign_in\"]/div[1]/div[4]/button")]
        IWebElement btnLogin { get; set; }

        public void FillNameAndPs(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public DashboardPage ClickRemAndBtn()
        {
            lableRememberMe.Click();
            btnLogin.Click();
            return new DashboardPage();
        }
    }
}