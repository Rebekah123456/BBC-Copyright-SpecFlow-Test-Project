using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BBC_Copyright_SpecFlow_Test_Project.PageObjects
{
    public class BBCPageObjects
    {
        //The URL of the BBC Home Page to be opened in the browser
        private const string BBCUrl = "http://bbc.co.uk";
        //Bug - 'more' not available in http://bbc.co.uk,have to go tohttp://bbc.co.uk/news

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;

        public BBCPageObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement newsLink => _webDriver.FindElement(By.XPath("//span[text()='News']"));
        private IWebElement moreDropDown => _webDriver.FindElement(By.XPath("//span[@class='nw-c-nav__wide-morebutton-separator']//span[text()='More']"));
        private IWebElement entertainmentAndArtsLink => _webDriver.FindElement(By.XPath("//a[@href='/news/entertainment_and_arts']"));
        private IWebElement footer => _webDriver.FindElement(By.XPath("//small"));

        public void ClickNews()
        {
            newsLink.Click();
        }

        public void ClickMore()
        {
            moreDropDown.Click();
        }

        public void ClickEntertainmentAndArts()
        {
            entertainmentAndArtsLink.Click();
        }

        public string GetFooterText()
        {
            return footer.Text;
        }

        public void OpenBBCHomePage()
        {
            _webDriver.Url = BBCUrl;
        }

        public void WaitForEntertainmentAndArtsPageToOpen()
        {
            //Open the calculator page in the browser if not opened yet
            if (_webDriver.Url != "https://www.bbc.co.uk/news/entertainment_and_arts")
            {
                var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(page => page.Title.StartsWith("Entertainment & Arts"));
            }
        }

    }
}
