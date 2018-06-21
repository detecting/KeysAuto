using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeysAuto.PublicPandM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public PropertyDetails PropertyDetails { get; set; }
        public FinanceDetails FinanceDetails { get; set; }


        public Login(LoginInfo loginInfo, PropertyDetails propertyDetails, FinanceDetails financeDetails)
        {
            LoginInfo = loginInfo;
            PropertyDetails = propertyDetails;
            FinanceDetails = financeDetails;
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

        [Given(@"I am at the PropertyOwners page")]
        public void GivenIAmAtThePropertyOwnersPage()
        {
        }

        [When(@"I click the  Add New Property button")]
        public void WhenIClickTheAddNewPropertyButton()
        {
            PropertyOwnersPage propertyOwnersPage = new PropertyOwnersPage();
            propertyOwnersPage.ClickAddNewProperty();
        }

        [Then(@"the Page will navigate to ""(.*)"" Page")]
        public void ThenThePageWillNavigateToPage(string addNewPropertyPage)
        {
            Assert.AreEqual(addNewPropertyPage, PublicPandM.PropertiesAndMethods._driver.Title);
        }


        [When(
            @"i fill the Property Details with the data from form below and also tick Owner Occupied and click Next button")]
        public void WhenIFillThePropertyDetailsWithTheDataFromFormBelowAndAlsoTickOwnerOccupiedAndClickNextButton(
            Table table)
        {
            //get the data from table
            var data = table.CreateDynamicSet();

            foreach (var item in data)
            {
                PropertyDetails.PropertyName = item.PropertyName;
                PropertyDetails.PropertyType = item.PropertyType;
                PropertyDetails.SearchAddress = item.SearchAddress;
                PropertyDetails.TargetRent = item.TargetRent.ToString();
                PropertyDetails.LandArea = item.LandArea.ToString();
                PropertyDetails.FloorArea = item.FloorArea.ToString();
                PropertyDetails.Bedroom = item.Bedroom.ToString();
                PropertyDetails.Bathroom = item.Bathroom.ToString();
                PropertyDetails.ParkingSpace = item.ParkingSpace.ToString();
                PropertyDetails.YearBuilt = item.YearBuilt.ToString();
                PropertyDetails.Description = item.Description;
                PropertyDetails.RentType = item.RentType;
            }

            //new AddNewPropertyPage
            AddNewPropertyPage addNewPropertyPage = new AddNewPropertyPage();

            //            Property Name
            addNewPropertyPage.PropertyName(PropertyDetails.PropertyName);
            //Property  type
            addNewPropertyPage.PropertyType(PropertyDetails.PropertyType);
            addNewPropertyPage.SearchAddress(PropertyDetails.SearchAddress);
            addNewPropertyPage.Description(PropertyDetails.Description);
            addNewPropertyPage.TargetRent(PropertyDetails.TargetRent);
            addNewPropertyPage.RentType(PropertyDetails.RentType);
            addNewPropertyPage.LandArea(PropertyDetails.LandArea);
            addNewPropertyPage.FloorArea(PropertyDetails.FloorArea);
            addNewPropertyPage.Bedrooms(PropertyDetails.Bedroom);
            addNewPropertyPage.Bathrooms(PropertyDetails.Bathroom);
            addNewPropertyPage.Carparks(PropertyDetails.ParkingSpace);
            addNewPropertyPage.YearBuilt(PropertyDetails.YearBuilt);
            addNewPropertyPage.OwnerOccupied();
            addNewPropertyPage.Next();
        }

        [Then(@"should mobe to ""(.*)"" Page")]
        public void ThenShouldMobeToPage(string financeDetailsString)
        {
            //Finance Details page
            FinancedetailsPage financedetailsPage = new FinancedetailsPage();
            Assert.AreEqual(financedetailsPage.Financedetails(), financeDetailsString);
        }


        [Given(@"I get into the FinanceDetails page")]
        public void GivenIGetIntoTheFinanceDetailsPage()
        {
        }

        [When(@"I fill all the form and I click save button")]
        public void WhenIFillAllTheFormAndIClickSaveButton(Table table)
        {
            //get the data form FinanceDetails
            var data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                FinanceDetails.HomeValue = item.HomeValue.ToString();
                FinanceDetails.HomeValueType = item.HomeValueType;
                FinanceDetails.Mortgage = item.Mortgage.ToString();
                FinanceDetails.PurchasePrice = item.PurchasePrice.ToString();
            }

            //new page
            FinancedetailsPage financedetailsPage = new FinancedetailsPage();

            financedetailsPage.PurchasePrice(FinanceDetails.PurchasePrice);
            financedetailsPage.Mortgage(FinanceDetails.Mortgage);
            financedetailsPage.HomeValue(FinanceDetails.HomeValue);
            financedetailsPage.HomeValueType(FinanceDetails.HomeValueType);
            financedetailsPage.Save();
        }

        [Then(@"the item wiil be added and the page move to ""(.*)"" Page")]
        public void ThenTheItemWiilBeAddedAndThePageMoveToPage(string myPropertiestitle)
        {
            Assert.AreEqual(myPropertiestitle, PublicPandM.PropertiesAndMethods._driver.Title);
        }


        [Given(@"I get into PropertyOwners")]
        public void GivenIGetIntoPropertyOwners()
        {
        }

        [When(@"I have entered ""(.*)"" in to the search box and I press the search button")]
        public void WhenIHaveEnteredInToTheSearchBoxAndIPressTheSearchButton(string inputSearch)
        {
            DashboardPage dashboardPage = new DashboardPage();
            dashboardPage.Search(inputSearch);
         }

        [Then(@"the result should show up")]
        public void ThenTheResultShouldShowUpWithoutAlert()
        {
            
        }


     }
}