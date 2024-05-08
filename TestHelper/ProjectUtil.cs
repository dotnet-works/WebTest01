using OpenQA.Selenium;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestHelper
{
    public class ProjectUtil
    {
        

        public static string ProjectPath   // property
        {
            get { return Directory.GetCurrentDirectory().Split("bin")[0];  }   // get method
        }
        public static string GetProjectBaseDir()
        {
            string projDir = Directory.GetCurrentDirectory().Split("bin")[0];
            return projDir;
        }

        public static byte[] getScreenShotAsBase64A(IWebDriver d, string img_name)
        {
            var b64String = ((ITakesScreenshot)d).GetScreenshot().AsBase64EncodedString;
            //byte[] encodedByte = System.Text.ASCIIEncoding.ASCII.GetBytes(b64String);
            byte[] encodedByte = Convert.FromBase64String(b64String);
            return encodedByte;
        }

        public static string getScreenShotAsBase64(IWebDriver d, string img_name)
        {
            var b64String = @"data:image/png;base64," + ((ITakesScreenshot)d).GetScreenshot().AsBase64EncodedString;
            return b64String;
        }

       
        public static void getImage(IWebDriver d)
        {
            var b64String = ((ITakesScreenshot)d).GetScreenshot().AsBase64EncodedString;
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(b64String);

            string filePath = GetProjectBaseDir()+"Data-Dir/MyImage.jpg";
            File.WriteAllBytes(filePath, Convert.FromBase64String(b64String));
            
        }

        public static void takeSave(IWebDriver d)
        {
            var b64String = ((ITakesScreenshot)d).GetScreenshot().AsBase64EncodedString;
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(b64String);

            string filePath = GetProjectBaseDir() + "Data-Dir/b64Image.png";
            ITakesScreenshot screenshotDriver = d as ITakesScreenshot;
            Screenshot ss = screenshotDriver.GetScreenshot();
            ss.SaveAsFile(filePath);

            

            string imgFormat;

            using (Image image = Image.FromFile(filePath))
            {
              using (MemoryStream m = new MemoryStream())
              {
                 string base64String;
                 image.Save(m, image.RawFormat);
                 byte[] imageBytes = m.ToArray();
                 base64String = Convert.ToBase64String(imageBytes);
                 Console.WriteLine(base64String);
                 imgFormat = base64String;
               }
            }





            //return xImg64;
        }



    }

    
}
