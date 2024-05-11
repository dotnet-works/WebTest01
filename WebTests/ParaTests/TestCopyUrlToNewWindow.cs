//using Allure.NUnit;
//using AutomationBase;
//using OpenQA.Selenium;
//using Pages.Amazon;
//using ReportManager;
//using System.Windows;

//namespace ParaTets
//{
//    [AllureNUnit]
//    [Parallelizable]
//    public class TestCopyUrlToNewWindow : TestBase
//    {
//        private MainPage amazonMainPage;
//        private ResultPage amazonResultPage;

//        [SetUp]
//        public void initPages()
//        {
//            amazonMainPage = new MainPage(driver);
//            //amazonResultPage= new ResultPage(driver);
//        }




//        [Test]
//        public void TestCopyUrlToNewWindow11()
//        {

//            amazonResultPage = amazonMainPage.SearchProduct("men's tShirt");
//            string _totalResults = amazonResultPage.GetTotalResultText();

//            TestContext.Out.WriteLine(String.Format("Results Found: {0}", _totalResults));

//            IList<IWebElement> _headElement = amazonResultPage.GetResultHeadingCount();
//            Console.WriteLine($"=== {_headElement.Count} ===");

//            _headElement[2].Click();
//            Thread.Sleep(4000);

//            IList<string> wins = driver.WindowHandles;

//            ReportLog.TestLogging("Total Windows found: " + wins.Count);


//            driver.SwitchTo().Window(wins[1]);
//            Thread.Sleep(1500);

//            driver.FindElement(By.XPath("//div[contains(@class,'ssf-background ssf-bg-count')]/a")).Click();
//            Thread.Sleep(6000);

//            IList<IWebElement> _shareOptions = driver.FindElements(By.XPath("//div[contains(@id,'a-popover-content')]/ul/li/a"));
//            _shareOptions[4].Click(); //copy url option
//            Thread.Sleep(2500);

//            var clipData = TextCopy.ClipboardService.GetText(); //Clipboard.GetDataObject().GetData(typeof(string));
//            Console.WriteLine("product url: {clipData}");
//            driver.SwitchTo().NewWindow(WindowType.Tab);
//            Thread.Sleep(1500);

//            driver.Navigate().GoToUrl(clipData);
//            driver.FindElement(By.Name("eleeeee")).Click() ;
//            string x ="Link copied!";
//        }
//    }
//}


