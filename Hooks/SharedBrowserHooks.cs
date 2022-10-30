using BBC_Copyright_SpecFlow_Test_Project.Drivers;
using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC_Copyright_SpecFlow_Test_Project.Hooks
{
    [Binding]
    public class SharedBrowserHooks
    {
        [AfterTestRun]
        public static void AfterTestRun(BrowserDriver driver)
        {
            driver.Dispose();
        }
    }
}
