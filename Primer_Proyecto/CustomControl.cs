using System;
using OpenQA.Selenium;

namespace Primer_Proyecto
{
    public class CustomControl : DriverHelper
    {
        public CustomControl()
        {
        }

        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//*[@id='{controlName}-awed']"));

            comboControl.Clear();
            //comboControl.SendKeys("Almond");
            comboControl.SendKeys(value + Keys.Enter);
        }
    }
}
