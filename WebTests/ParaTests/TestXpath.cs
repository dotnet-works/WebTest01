using Allure.NUnit;
using AutomationBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using Pages.Amazon;
using TestHelper;



namespace WebTests.ParaTests
{


    [AllureNUnit]
    [Parallelizable]
    [Category("sample")]
    public class TestXpath : TestBase
    {
        private MainPage amazonMainPage;
        private ResultPage amazonResultPage;
        

        [SetUp]
        public void initPages()
        {
            string videoPath = Path.Combine(ProjectUtil.ProjectPath, "test.mp4");
            amazonMainPage = new MainPage(driver);
            
        }

        [Test]
        [Ignore("Ignore a test")]
        public void TestXpathPrecedingSibling()
        {

            amazonResultPage = amazonMainPage.SearchProduct("mobile");
            string _totalResults = amazonResultPage.GetTotalResultText();

            TestContext.Out.WriteLine(String.Format("Results Found: {0}", _totalResults));

            IList<IWebElement> _headElement = amazonResultPage.GetResultHeadingCount();
            Console.WriteLine($"=== {_headElement.Count} ===");

            ClickElementByLabel("Get It by Tomorrow");
            Thread.Sleep(2000);

        }

        [Test]
        public void TestSelectList()
        {
            //IWebElement _amazonSelectList = driver.FindElement(By.Id("searchDropdownBox"));
            //_amazonSelectList.Click();
            //Thread.Sleep(2000);

            SelectElement amazonSearchDropDown1 = new SelectElement(driver.FindElement(By.Id("searchDropdownBox")));
            amazonSearchDropDown1.SelectByText("MP3 Music");
            Thread.Sleep(3000);
            driver.FindElement(amazonMainPage._searchBTN).Click();
            Thread.Sleep(3000);

            SelectElement amazonSearchDropDown2 = new SelectElement(driver.FindElement(By.Id("searchDropdownBox")));
            amazonSearchDropDown2.SelectByText("Apps & Games");
            Thread.Sleep(3000);
            driver.FindElement(amazonMainPage._searchBTN).Click();
            Thread.Sleep(3000);
            Console.WriteLine("try new push");
        }


        public IWebElement GetElementByLabel(string label)
        {
            By _xpath = By.XPath("//div[@id='deliveryRefinements']//span[contains(text(),'" + label + "')]//preceding-sibling::div/label/input");
            return driver.FindElement(_xpath);
        }

        public bool ClickElementByLabel(string label)
        {
            By _xpath;
            bool _result;
            try
            {
                _xpath = By.XPath("//div[@id='deliveryRefinements']//span[contains(text(),'" + label + "')]//preceding-sibling::div/label/input");
                driver.ExecuteJavaScript("arguments[0].click();", driver.FindElement(_xpath));
                _result = true;
            }
            catch(Exception ex)
            {
                _result = false;
                Console.WriteLine(ex.Message);
            }
            return _result;
        }


    }
}
