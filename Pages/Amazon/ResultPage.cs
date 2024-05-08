using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Amazon
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        protected By _results = By.XPath("//span[@data-component-type='s-result-info-bar']/div/h1/div/div[1]");
        protected By _resultHeading = By.XPath("//div[contains(@class,'a-section a-spacing-base a-text-center')]//h2/a");
        
        public string GetTotalResultText() {  return driver.FindElement(_results).Text;  }

        public IList<IWebElement> GetResultHeadingCount(By headElement=null)
        {
            IList<IWebElement> _listHeadings = null;
            if (headElement !=null)
            {
                _listHeadings = driver.FindElements(headElement);
            }
            else
            {
                _listHeadings = driver.FindElements(_resultHeading);
            }
            return _listHeadings;  
        }





    }
}
