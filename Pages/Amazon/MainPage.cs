using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ReportManager;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Pages.Amazon
{
    public class MainPage
    {
        IWebDriver driver;
        string _baseURL = "https://www.amazon.in/";

        public MainPage(IWebDriver driver)
        {
           this.driver = driver;
        }

        internal By _searchBox = By.Id("twotabsearchtextbox");
        internal By _searchBTN = By.Id("nav-search-submit-text");
        internal By _results = By.XPath("//span[@data-component-type='s-result-info-bar']/div/h1/div/div[1]");


        public void GoToSite()
        {
            //condition ? consequent : alternative
            //is this condition true ? yes : no
            //string siteURL = url ? url: baseURL;
            driver.Url=_baseURL;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_results));
        }

        public ResultPage SearchProduct(string productName)
        {
            try
            {
                driver.FindElement(_searchBox).Click();
                driver.FindElement(_searchBox).SendKeys(productName);
                driver.FindElement(_searchBTN).Click();
                
                
            }
            catch (Exception ex)
            {
                ReportLog.TestLogging(ex.Message);
            }
            return new ResultPage(driver);
        }

    }
}
