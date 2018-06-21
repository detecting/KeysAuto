using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KeysAuto.PublicPandM
{
    public class PropertiesAndMethods
    {
        public static IWebDriver _driver { get; set; }
        public static string url = "http://new-keys.azurewebsites.net/Account/Login";
    }


    public class FinanceDetails
    {
        public string PurchasePrice { get; set; }
        public string Mortgage { get; set; }
        public string HomeValue { get; set; }
        public string HomeValueType { get; set; }
    }
    public class PropertyDetails
    {
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public string SearchAddress { get; set; }
        public string TargetRent { get; set; }
        public string LandArea { get; set; }
        public string FloorArea { get; set; }
        public string Bedroom { get; set; }
        public string Bathroom { get; set; }
        public string ParkingSpace { get; set; }
        public string YearBuilt { get; set; }
        public string Description { get; set; }
        public string RentType { get; set; }
    }

    public class LoginInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}