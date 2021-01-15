using System;
using NUnit.Framework;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using Primer_Proyecto.Pages;

namespace Primer_Proyecto
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new SafariDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("tomato");

            Driver.FindElement(By.XPath("//*[@id='btnCookie']")).Click();

            Driver.FindElement(By.XPath("//*[@id='maincont']/div[1]/div[4]/div[2]/div[2]/div/ul/li[1]/label/div[1]/div/div")).Click();

            //CustomControl control = new CustomControl();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","almond");

            //string comboxControlName = "ContentPlaceHolder1_AllMealsCombo";

            //Driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_AllMealsCombo - dropmenu']/div[2]/ul/li[1]")).Click();
            //Driver.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_AllMealsCombo - dropmenu']/div[2]/ul/li[1]")).SendKeys("almond" + Keys.Enter);

            //Console.WriteLine("Test1");
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {

            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPages loginPages = new LoginPages();

            homePage.ClickLogin();

            loginPages.EnterUserNameAndPasword("admin","password");
            loginPages.ClickLogin(); 

        }
    }

}