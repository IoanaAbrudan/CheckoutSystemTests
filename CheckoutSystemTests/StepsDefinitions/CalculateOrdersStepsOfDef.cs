using CheckoutSystemTests.Core;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CheckoutSystemTests.StepsDefinitions
{
    [Binding]
    public class CalculateOrdersStepsOfDef
    {
        private CheckoutSystemHelper _checkoutSystem;
        private ScenarioContext _scenarioContext;
        public CalculateOrdersStepsOfDef(CheckoutSystemHelper checkoutSystem, ScenarioContext scenarioContext)
        {
            _checkoutSystem = checkoutSystem;
             _scenarioContext = scenarioContext;
        }

        [Given(@"there is a order (.*) startes (.*) mains and (.*) drinks")]
        public void GivenThereIsAOrderStartesMainsAndDrinks(int nrOfStarters, int nrOfMains, int nrOFDrinks)
        {
            _scenarioContext["starters"] = nrOfStarters;
            _scenarioContext["mains"] = nrOfMains;
            _scenarioContext["drinks"] = nrOFDrinks;
        }

        [Given(@"the order is sent to endpoint")]
        [When(@"the order is sent to endpoint")]
        public void WhenTheOrderIsSentToEndpoint()
        {
           var cost = _checkoutSystem.CalculateCheckOut((int)_scenarioContext["starters"], (int)_scenarioContext["mains"], (int)_scenarioContext["drinks"]);
            _scenarioContext["finalOrder"] = cost;
        }

        [Given(@"the order has been updated with (.*) startes (.*) mains and (.*) drinks")]
        public void GivenTheOrderHasBeenUpdatedWithStartesMainsAndDrinks(int nrOfStarters, int nrOfMains, int nrOfDrinks)
        {
            var cost = _checkoutSystem.CalculateCheckOut(nrOfStarters, nrOfMains, nrOfDrinks);
            _scenarioContext["finalOrder"] = cost;
        }

        [Then(@"the order is calculated corectly")]
        public void ThenTheOrderIsCalculatedCorectly()
        {
            Assert.IsNotNull(_scenarioContext["finalOrder"]);
            Assert.AreNotEqual(_scenarioContext["finalOrder"], 0);
        }

    }
}
