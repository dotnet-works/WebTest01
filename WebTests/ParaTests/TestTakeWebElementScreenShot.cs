using Allure.NUnit;
using AutomationBase;
using OpenQA.Selenium;
using Pages.Amazon;
using ReportManager;
using WebTest01.TestHelper;


namespace ParaTets
{
    [AllureNUnit]
    [Parallelizable]
    public class TestTakeWebElementScreenShot : TestBase
    {
        private MainPage amazonMainPage;
        private ResultPage amazonResultPage;

        [SetUp]
        public void initPages()
        {
            amazonMainPage = new MainPage(driver);
            //amazonResultPage= new ResultPage(driver);
        }

        [Test]
        public void TestWebElementScreenShot()
        {

            amazonResultPage = amazonMainPage.SearchProduct("men's tShirt");
            string _totalResults = amazonResultPage.GetTotalResultText();

            TestContext.Out.WriteLine(String.Format("Results Found: {0}", _totalResults));

            IList<IWebElement> _headElement = amazonResultPage.GetResultHeadingCount();
            Console.WriteLine($"=== {_headElement.Count} ===");

            _headElement[2].Click();
            Thread.Sleep(4000);

            IList<string> wins = driver.WindowHandles;

            ReportLog.TestLogging("Total Windows found: " + wins.Count);


            driver.SwitchTo().Window(wins[1]);
            Thread.Sleep(1500);

            IWebElement screenShotEle = driver.FindElement(By.Id("imgTagWrapperId"));
            
            ExtentTestManager.GetExtentTest().AddScreenCaptureFromPath(new WebHelper(driver).GetElementScreenShot(screenShotEle));

            



        }
    }
}
