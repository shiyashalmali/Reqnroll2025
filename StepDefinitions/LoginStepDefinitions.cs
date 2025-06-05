using Reqnroll;
using ReqnrollProject2025.Pages;
using ReqnrollProject2025.Utilities;
using System;

namespace ReqnrollProject2025.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        

        private readonly LoginPage lp;

        public LoginStepDefinitions(DriverContext context)
        {
            lp = new LoginPage(context.Driver);
        }


        [Given("User is on the orangehrm login page")]
        public void GivenUserIsOnTheOrangehrmLoginPage()
        {
            lp.launchbrowser();
            Thread.Sleep(2000);
        }

        [When("User enters the username {string} and password {string} in the text fields")]
        public void WhenUserEntersTheUsernameAndPasswordInTheTextFields(string username, string password)
        {
            Utilities.Log.Info("Users enters username and password");
            lp.enterusernamepass(username, password);
            Thread.Sleep(2000);
        }


        [When("User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            Utilities.Log.Info("Users clicks submit butoon");
            lp.submit();
            Thread.Sleep(2000);
        }

        [Then("User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Utilities.Log.Info("Users navigates to home page");
            lp.homepagedisplay();
            Thread.Sleep(2000);
        }


        [When("User enters the {string} and {string} in the input fields")]
        public void WhenUserEntersTheAndInTheInputFields(string admin, string p1)
        {
            Utilities.Log.Info("Users enters username and password");
            Console.WriteLine("User enters the username and the password");
            Thread.Sleep(2000);

        }


        [Then("User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(DataTable dataTable)
        {


            foreach (var row in dataTable.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + "," + country);
            }
        }
    }


}
