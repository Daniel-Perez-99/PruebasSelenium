using System;
using OpenQA.Selenium;

namespace Primer_Proyecto.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.XPath("//*[@id='loginLink']"));

        //IWebElement lnkLogoff => Driver.FindElement(By.Name("Log off"));


        public void ClickLogin()
        {
            lnkLogin.Click();
        }

        //public bool IsLogOffExist() => lnkLogoff.Displayed;
    }
}
