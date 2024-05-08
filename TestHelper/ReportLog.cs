using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using ReportManager;


namespace TestHelper
{
    internal class ReportLog
    {
       public static void Pass(string message)
        {
             ExtentTestManager.GetExtentTest().Pass(message);
            
        }
        /*
        public static void Fail(string message)
        {
            ExtentTestManager.GetExtentTest().Fail(message);
            
        }

        public static void Fail(string message, string base64Png=null) 
        {
            //var mediaModel1 = MediaEntityBuilder.CreateScreenCaptureFromBase64String("screenshot.png").Build();
            //var mediaModel = media.CreateScreenCaptureFromPath("screenshot.png").Build();
            //test.Fail("details", mediaModel);

            ExtentTestManager.GetExtentTest().Fail(message);
            ExtentTestManager.GetExtentTest().Fail(message, MediaEntityBuilder.CreateScreenCaptureFromPath(base64Png).Build());
            
        }*/

        public static void Fail(string message)
        {
           ExtentTestManager.GetExtentTest().Fail(message);
        }
        public static void Fail(string message, Media m = null)
        {
            
            ExtentTestManager.GetExtentTest().Fail(message, m);
        }

        public static void Fail(string message, String m = null)
        {
            
            ExtentTestManager.GetExtentTest().Fail(message).AddScreenCaptureFromBase64String(m);
        }

        public static void Skip(string message)
        {
            ExtentTestManager.GetExtentTest().Skip(message);
            //ExtentTestManager.GetExtentTest().Fail(message,);
        }

        public static void TestLogging(string message) { ExtentTestManager.GetExtentTest().Info(message); }


    }
}
