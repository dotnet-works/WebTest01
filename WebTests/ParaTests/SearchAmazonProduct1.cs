//using Allure.NUnit;
//using AutomationBase;
//using OpenQA.Selenium;


//namespace ParaTets
//{
//    [AllureNUnit]
//    [Parallelizable]
//    public class SearchAmazonProduct1 : TestBase
//    {
//        protected By _searchBox = By.Id("twotabsearchtextbox");
//        protected By _searchBTN = By.Id("nav-search-submit-text");
//        protected By _results = By.XPath("//span[@data-component-type='s-result-info-bar']/div/h1/div/div[1]");

//        [Test]
//        public void Test1()
//        {
//            IWebElement searchTextBox = driver.FindElement(_searchBox);
//            searchTextBox.SendKeys("men's denim");
//            driver.FindElement(_searchBTN).Click();
//            Thread.Sleep(5000);
//            // // string _totalResults = driver.FindElement(By.CssSelector("div.a-section.a-spacing-small.a-spacing-top-small")).Text;
//            string _totalResults = driver.FindElement(_results).Text;
//            Console.WriteLine(String.Format("Results Found: {0}", _totalResults));
//            TestContext.Out.WriteLine(String.Format("Results Found: {0}", _totalResults));

//        }
//    }
//}
