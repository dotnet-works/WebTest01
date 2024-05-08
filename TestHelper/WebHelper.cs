using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System.Drawing;
using System.IO;
using TestHelper;
using static System.Net.Mime.MediaTypeNames;

namespace WebTest01.TestHelper
{
    public class WebHelper
    {
        IWebDriver driver;
        public WebHelper(IWebDriver driver)
        {
            this.driver = driver;
        }


        public string GetElementScreenShot(IWebElement element)
        {
            //Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();
            //var img = System.Drawing.Image.FromStream(new MemoryStream(sc.AsByteArray));
            //img.Save("./test.png", System.Drawing.Imaging.ImageFormat.Png);
            //return img.Clone(new Rectangle(element.Location, element.Size), img.PixelFormat);


            Screenshot screenshot = ((WebElement)element).GetScreenshot();
            string fileName = DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss_tt") + ".png";
            string file = ProjectUtil.ProjectPath + "Reports/" + fileName;
            screenshot.SaveAsFile(file); //, System.Drawing.Imaging.ImageFormat.Png);
            //screenshot.SaveAsFile("test.png", ScreenshotImageFormat.Png);
            Console.WriteLine(ProjectUtil.ProjectPath);
            return file;
            //try
            //{
            //string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
            //Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
            //Bitmap screenshot = new Bitmap(new MemoryStream(byteArray));
            //Rectangle croppedImage = new Rectangle(element.Location.X, element.Location.Y, element.Size.Width, element.Size.Height);
            //screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);
            ////screenshot.Save(String.Format(@"C:\SeleniumScreenshots\" + fileName, System.Drawing.Imaging.ImageFormat.Png));
            ////screenshot.Save(String.Format(ProjectUtil.ProjectPath+"Reports/"+ fileName, System.Drawing.Imaging.ImageFormat.Png));
            //screenshot.Save("test.png", System.Drawing.Imaging.ImageFormat.Png);
            //}
            //catch (Exception e)
            //{
            //    //logger.Error(e.StackTrace + ' ' + e.Message);
            //}





        }
    }
}
