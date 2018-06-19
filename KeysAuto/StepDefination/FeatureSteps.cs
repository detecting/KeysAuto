using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeysAuto.PublicPandM;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KeysAuto.Pages
{
    [Binding]
//    [Scope(Scenario = "Login")]
    public sealed class Login
    {
        //context injection
        public LoginInfo LoginInfo { get; set; }

        public Login(LoginInfo loginInfo)
        {
            this.LoginInfo = loginInfo;
        }

        [Given(@"I have open the application")]
        public void GivenIHaveOpenTheApplication()
        {
            Browser browser = new Browser();
        }


        [Then(@"I should see the Login Page title is ""(.*)""")]
        public void ThenIShouldSeeTheLoginPageTitleIs(string title)
        {
            Assert.AreEqual(PublicPandM.PropertiesAndMethods._driver.Title, title);
        }

        [When(@"I fill userName and password in form tick Remember Me and click Login Button")]
        public void WhenIFillUserNameAndPasswordInFormTickRememberMeAndClickLoginButton(Table table)
        {
            //get the username and passwd from table;
            var data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                LoginInfo.UserName = item.UserName;
                LoginInfo.Password = item.Password;
            }

            //need to initialize here.
            //initial the LoginPage

            LoginPage loginPage = new LoginPage();
            loginPage.FillNameAndPs(LoginInfo.UserName, LoginInfo.Password);
            loginPage.ClickRemAndBtn();
        }

        [Then(@"I will get into the ""(.*)"" Page")]
        public void ThenIWillGetIntoThePage(string dashboard)
        {
            Assert.AreEqual(PublicPandM.PropertiesAndMethods._driver.Title, dashboard);
        }

        [Given(@"at the Dashboard page")]
        public void GivenAtTheDashboardPage()
        {
        }

        [When(@"I select ""(.*)"" under Owner")]
        public void WhenISelectUnserOwner(string properties)
        {
            DashboardPage dashboardPage = new DashboardPage();
            dashboardPage.SelectPropertiesUnderOwner(properties);
        }

        [Then(@"I will go to ""(.*)"" Page")]
        public void ThenIWillGoToPage(string properties)
        {
            Assert.AreEqual(PublicPandM.PropertiesAndMethods._driver.Title, properties);
        }
    }
}