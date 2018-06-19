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

    public class LoginInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}