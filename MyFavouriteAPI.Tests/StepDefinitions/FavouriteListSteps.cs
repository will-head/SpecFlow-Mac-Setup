using System;
using TechTalk.SpecFlow;

namespace MyFavouriteAPI.Tests.StepDefinitions
{
    [Binding]
    public class FavouriteListSteps
    {
        [When(@"I create a new favourite list")]
        public void WhenICreateANewFavouriteList()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the favourite list should be empty")]
        public void ThenTheFavouriteListShouldBeEmpty()
        {
            ScenarioContext.Current.Pending();
        }
    }
}