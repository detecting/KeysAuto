using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace KeysAuto.Pages
{
    [Binding]
    [Scope(Scenario = "Login success")]
    public sealed  class Login
    {
        [Given(@"I have open the application")]
        public void GivenIHaveOpenTheApplication()
        {

        }

        [Then(@"I should see the Login Page")]
        public void ThenIShouldSeeTheLoginPage()
        {
        }

        [When(@"I fill (.*) and (.*) in form")]
        public void WhenIFillAndInForm(string userName, string password)
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I tick the Remember Me and Login Button")]
        public void WhenITickTheRememberMeAndLoginButton()
        {
        }

        [Then(@"I will get into the Dashboard Page")]
        public void ThenIWillGetIntoTheDashboardPage()
        {
        }
    }
}