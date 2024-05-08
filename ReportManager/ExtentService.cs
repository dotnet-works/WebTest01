using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using TestHelper;


namespace ReportManager
{
    /*
    public class ExtentService
    {
        public static ExtentReports extent;

        public static ExtentReports GetExtent()
        {

            if (extent == null)
            {
                extent = new ExtentReports();
                string reportDir = Path.Combine(ProjectUtil.GetProjectBaseDir(), "Reports");
                if (!Directory.Exists(reportDir))
                    Directory.CreateDirectory(reportDir);

                string path = Path.Combine(reportDir, "index.html");
                var reporter = new ExtentSparkReporter(path);
                // var reporter = new ExtentHtmlReporter(path);
                reporter.Config.Theme = Theme.Dark;
                reporter.Config.DocumentTitle = "Automation Report";
                extent.AttachReporter(reporter);
                
            }
            return extent;
        }
    }*/


    //public class ExtentService
    //{
    //    public static ExtentReports extent;

    //    public static ExtentReports GetExtent()
    //    {

    //        if (extent == null)
    //        {
    //            extent = new ExtentReports();
    //            string reportDir = Path.Combine(ProjectUtil.GetProjectBaseDir(), "Reports");
    //            if (!Directory.Exists(reportDir))
    //                Directory.CreateDirectory(reportDir);

    //            string path = Path.Combine(reportDir, "index.html");
    //            var reporter = new ExtentSparkReporter(path);
    //            var spark = new ExtentSparkReporter(reportDir+"Spark.html");
    //            // var reporter = new ExtentHtmlReporter(path);
    //            reporter.Config.Theme = Theme.Dark;
    //            reporter.Config.DocumentTitle = "Automation Report";
    //            //spark.LoadXMLConfig(ProjectUtil.GetProjectBaseDir() + "spark-config.xml");
    //            spark.LoadJSONConfig(ProjectUtil.GetProjectBaseDir() + "spark-config.json");
    //            extent.AttachReporter(reporter);

    //        }
    //        return extent;
    //    }
    //}

    public class ExtentService
    {
        public static ExtentReports extent;

        public static ExtentReports GetExtent()
        {

            if (extent == null)
            {
                extent = new ExtentReports();
                string reportDir = Path.Combine(ProjectUtil.GetProjectBaseDir(), "Reports");
                Console.WriteLine(reportDir);
                if (!Directory.Exists(reportDir))
                    Directory.CreateDirectory(reportDir);

                string path = Path.Combine(reportDir, "index.html");
                ExtentSparkReporter reporter = new ExtentSparkReporter(path);
                reporter.LoadJSONConfig(ProjectUtil.GetProjectBaseDir() + "config/spark-config.json");
                //reporter.LoadXMLConfig(ProjectUtil.GetProjectBaseDir() + "config/spark-config.xml");
                extent.AttachReporter(reporter);

            }
            return extent;
        }
    }


}
