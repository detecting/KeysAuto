using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeysAuto.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KeysAuto.StepDefination
{
    [Binding]
    [Scope(Scenario = "MovetoPropertiesPage")]
    public sealed class MoveToPropertis
    {
        [Given(@"at the Dashboard page")]
        public void GivenAtTheDashboardPage()
        {
            ScenarioContext.Current.Pending();
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