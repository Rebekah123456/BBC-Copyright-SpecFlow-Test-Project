using BBC_Copyright_SpecFlow_Test_Project.Drivers;
using BBC_Copyright_SpecFlow_Test_Project.PageObjects;

namespace BBC_Copyright_SpecFlow_Test_Project.Steps
{
    [Binding]
    public sealed class BBCStepDefinitions
    {
        //Page Object for BBC
        private readonly BBCPageObjects _bbcPageObjects;

        public BBCStepDefinitions(BrowserDriver browserDriver)
        {
            _bbcPageObjects = new BBCPageObjects(browserDriver.Current);
        }

        [Given("I am on the BBC Homepage")]
        public void GivenIAmOnTheBBCHomepage()
        {
            _bbcPageObjects.OpenBBCHomePage();
        }

        [When("I navaigate to the Entertainment & Arts page")]
        public void WhenINavigateToTheEntertainmentAndArtsPage()
        {
            _bbcPageObjects.ClickNews();
            _bbcPageObjects.ClickMore();
            _bbcPageObjects.ClickEntertainmentAndArts();
            _bbcPageObjects.WaitForEntertainmentAndArtsPageToOpen();
        }

        [Then("the footer text equals (.*)")]
        public void ThenTheFooterTextEquals(string expectedFooterText)
        {
            string actualFooterText = _bbcPageObjects.GetFooterText();
            //Assert.AreEqual(expectedFooterText, actualFooterText, "Footer text not as expected");
            Assert.IsTrue(actualFooterText.Contains(expectedFooterText), "Expected Footer text not present in Footer");
            
        }
    }
}
