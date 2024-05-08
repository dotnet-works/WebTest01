using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TestHelper
{
    public class WaitConditions
    {
        IWebDriver driver;
        WebDriverWait _wait;
        public WaitConditions(IWebDriver driver)
        {
            this.driver = driver;
            _wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
        }

        public  IList<IWebElement> ExpectedVisibleAllEle(By _By)
        {
            return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_By));
        }

        public IWebElement ExpectedVisibleEle(By _By)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(_By));
        }




    }
}
