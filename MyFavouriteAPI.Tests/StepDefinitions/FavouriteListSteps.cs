using System;
using TechTalk.SpecFlow;

namespace MyFavouriteAPI.Tests.StepDefinitions
{
    [Binding]
    public class FavouriteListSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public FavouriteListSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"I create a new favourite list")]
        public void WhenICreateANewFavouriteList()
        {
            _scenarioContext.Pending();
        }

        [Then(@"the favourite list should be created as empty")]
        public void ThenTheFavouriteListShouldBeCreatedAsEmpty()
        {
            _scenarioContext.Pending();
        }
    }
}
