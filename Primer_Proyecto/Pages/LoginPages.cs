using OpenQA.Selenium;


namespace Primer_Proyecto
{
    public class LoginPages : DriverHelper
    {
        IWebElement textUserName => Driver.FindElement(By.XPath("//*[@id='UserName']"));
        IWebElement textPassWord => Driver.FindElement(By.XPath("//*[@id='Password']"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[4]/div/input"));
        
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