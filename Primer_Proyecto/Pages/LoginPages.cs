using OpenQA.Selenium;


namespace Primer_Proyecto
{
    public class LoginPages : DriverHelper
    {
        IWebElement textUserName => Driver.FindElement(By.Name("Username"));
        IWebElement textPassWord => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.Name("Log in"));
        
        public void EnterUserNameAndPasword(string userName, string passWord)
        {
           textUserName.SendKeys(userName);
           textPassWord.SendKeys(passWord);

        }

        public void ClickLogin()
        {
           btnLogin.Click();
        }
    }
}