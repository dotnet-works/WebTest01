using Allure.Net.Commons;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using ReportManager;
using Pages.Amazon;
using OpenQA.Selenium.Chrome;

namespace AutomationBase
{
    public class TestBase
    {
        public IWebDriver driver;
        private string baseURL = "https://www.calculator.net/";
        public const string BROWSER = "CHROME";

        //private MainPage amazonMainPage;
        //private ResultPage amazonResultPage;



        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            string browserName = Environment.GetEnvironmentVariable("BROWSER");
            string ENV2 = Environment.GetEnvironmentVariable("ENV2");
            string platform = Environment.OSVersion.ToString();

            if (ENV2 == "") { Console.WriteLine("ENV2 is empty");  }
            else if(ENV2==null) { Console.WriteLine("ENV2 is null"); }

            Console.WriteLine(ENV2.GetType());
            
            Console.WriteLine($"Param: {TestContext.Parameters["param1"]}");
            Console.WriteLine($"browser: {browserName} platform: {platform}");
            
            TestContext.WriteLine($"Param: {TestContext.Parameters["param1"]}");
            TestContext.WriteLine($"browser: {browserName} platform: {platform}");






            //switch (browserName.ToLower())
            //{
            //    case "ff":
            //        Console.WriteLine("");
            //        break;
            //    case "firefox":
            //        Console.WriteLine("");
            //        break;
            //    case "chrome":
            //        Console.WriteLine("");
            //        break;
            //    default:
            //        throw new Exception("No Browser is defined");

            //}



            AllureLifecycle.Instance.CleanupResultDirectory();
            ExtentTestManager.CreateParentTest(GetType().Name);
        }

        [OneTimeTearDown]
        public void GlobalTestTearDown()
        {
            ExtentService.GetExtent().Flush();

        }

        [SetUp]
        public void InitSetUp()
        {
            
            string browserMode = Environment.GetEnvironmentVariable("BROWSERMODE");
            string browserName = Environment.GetEnvironmentVariable("BROWSER");
            string ENV2 = Environment.GetEnvironmentVariable("ENV2");
            string platform = Environment.OSVersion.ToString();

            if (ENV2 == "") { Console.WriteLine("ENV2 is empty"); }
            else if (ENV2 == null) { Console.WriteLine("ENV2 is null"); }

            Console.WriteLine(ENV2.GetType());




            //Console.WriteLine($"Param: {TestContext.Parameters["param1"]}");
            Console.WriteLine($"browser: {browserName} platform: {platform}");
            //TestContext.WriteLine($"Param: {TestContext.Parameters["param1"]}");
            //TestContext.WriteLine($"browser: {browserName} platform: {platform}");

            ExtentTestManager.CreateTest(TestContext.CurrentContext.Test.Name);

            var user = Environment.GetEnvironmentVariable("TestUser");
            Console.WriteLine(String.Format("CMD Pass User {0}", user));





            //FirefoxOptions _ffOptions = new FirefoxOptions();

            //_ffOptions.LogLevel = FirefoxDriverLogLevel.Fatal;
            //_ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.Off); //.All);
            //                                                               // _ffOptions.AddArguments("--headless");
            //driver = new FirefoxDriver(_ffOptions);

            driver = new BrowserType(driver, "chrome").SelectBrowser();

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2500);
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void TestTearDown()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var ErrorMsg = string.IsNullOrEmpty(TestContext.CurrentContext.Result.Message) ? "" : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);
                var stackTrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "" : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);

                switch (status)
                {
                    case TestStatus.Failed:
                        Console.WriteLine("Test Failed");
                        ReportLog.Fail(ErrorMsg);
                        //ReportLog.Fail(stackTrace);
                        //ReportLog.Fail(stackTrace, captureScreen("TestFile"));
                        ReportLog.Fail(stackTrace, captureScreen1("FailFile"));

                        break;
                    case TestStatus.Skipped:
                        Console.WriteLine("Test Skipped");
                        break;
                    case TestStatus.Passed:
                        Console.WriteLine("Test Passed");
                        ReportLog.Pass("Test Passed");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Exception: " + ex);
            }
            finally
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        public String captureScreen(string ssName) { return ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString; }

        public Media captureScreen1(string ssName)
        {
            var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            Media x = MediaEntityBuilder.CreateScreenCaptureFromBase64String(ss, ssName).Build();
            return x;
        }


    }


    public class BrowserType
    {
        private string browserName;
        //private string platformType;
        IWebDriver driver;
        public BrowserType(IWebDriver driver,string browserName) 
        {

            this.driver = driver;
            this.browserName = browserName;
            //this.platformType = platformType;
        }

        public IWebDriver SelectBrowser()
        {
            //if(platformType.ToLower().Contains("Windows")) { }
            //else {  }

            switch (browserName.ToLower())
            {
                case "ff":
                case "firefox":
                    Console.WriteLine("Browser firefox is selected");
                    FirefoxOptions _ffOptions = new FirefoxOptions();

                    _ffOptions.LogLevel = FirefoxDriverLogLevel.Fatal;
                    _ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.Off); //.All);
                                                                                   // _ffOptions.AddArguments("--headless");
                    driver = new FirefoxDriver(_ffOptions);
                    break;
           
                case "chrome":
                    Console.WriteLine("Browser Chrome is selected");
                    ChromeOptions _chromeOptions = new ChromeOptions();
                    _chromeOptions.AddArguments("--disable-dev-shm-usage");
                    _chromeOptions.AddArguments("--no-sandbox");
                    _chromeOptions.AddArguments("--log-level=3");
                    // _chromeOptions.AddArguments("--headless");
                    driver = new ChromeDriver(_chromeOptions);
                    break;
                default:
                    throw new Exception("No Browser is defined");

            }
            return driver;

        }










    } 
}

