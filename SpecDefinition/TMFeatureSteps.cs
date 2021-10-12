using System;
using TechTalk.SpecFlow;

namespace Selenium_DOTNET_T1.SpecDefinition
{
    [Binding]
    public class TMFeatureSteps
    {
        [Given(@"I logged in to turnup prtal successfully")]
        public void GivenILoggedInToTurnupPrtalSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Then the record shoul be create successfully")]
        public void ThenThenTheRecordShoulBeCreateSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
