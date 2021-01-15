using System;
using OpenQA.Selenium;

namespace Primer_Proyecto.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.Name("Login"));

        public void ClickLogin() => lnkLogin.Click();

    }
}
