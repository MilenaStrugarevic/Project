using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Page
{
    public class DashboardPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement UserManu => driver.FindElement(By.ClassName("oxd-userdropdown-name"));
        public void SelectOption()
        {
            SelectElement element = new SelectElement();
        }
    }
}
