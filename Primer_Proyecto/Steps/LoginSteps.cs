using System;
using Primer_Proyecto.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Primer_Proyecto.Steps
{
    [Binding]

    public class LoginSteps : DriverHelper
    {

        HomePage homePage = new HomePage();
        LoginPages loginPages = new LoginPages();

        [Given(@"I navigate to application")]

        public void GivenINavigateToApplication()
        {
            ScenarioContext.Current.Pending(); 
        }

        //

        [Given(@"I click the Login link")]

        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
        }

        //

        [Given(@"I enter username and password")]

        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPages.EnterUserNameAndPasword(data.UserName, data.Password);
        }

        //

        [Given(@"I click login")]

        public void GivenIClickLogin()
        {
            loginPages.ClickLogin();
        }

        //

        [Then(@"I should see user logged in to the application")]

        public void GivenIShouldSeeUserLoggedInToTheApplication()
        {
            //ScenarioContext.Current.Pending();
        }

        //

        public LoginSteps()
        {
        }
    }
}
