//using Allure.NUnit;
//using AutomationBase;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TestHelper;
//using static System.Net.Mime.MediaTypeNames;

//namespace  WebTests.SeqTests
//{
//    [AllureNUnit]
//    [Parallelizable]
//    public class TestExecutionVideo:TestBase
//    {
//        public static Process process;
//        string proj = ProjectUtil.ProjectPath;

//        [SetUp]
//        public void initTest()
//        {
//           process = new Process();
//            //process.StartInfo.FileName = @"C:\Program Files (x86)\StartScreenRecording.bat";
//            process.StartInfo.FileName = @"C:\FFMpeg\ffmpeg-7\bin\video_grabber.bat";
//            process.StartInfo.CreateNoWindow = true;
//            process.StartInfo.RedirectStandardInput = true;// this required to send input to the current process window.
//            bool started = process.Start();
//            if (started == true) { 
//                Console.WriteLine("Bat file started");  
//            }
//        }

//        [TearDown]
//        public void tearDownTest()
//        {
//            //StreamWriter mystreamwriter = process.StandardInput; // this required to send standardinput stream, nothing fancy 

//            //this will send q as an input to the ffmpeg process window making it stop ,
//            //please cross check in task manager once if the ffmpeg is still running or closed.
//            //string key = "q";
//            //byte[] bytes = Encoding.ASCII.GetBytes(key);
//            //string someString = Encoding.ASCII.GetString(bytes);
//            //Console.WriteLine(someString);

//            //String inputText = "q";
//            ////inputText = Console.ReadLine();

//            //myStreamWriter.AutoFlush = true;
//            //myStreamWriter.WriteLine(inputText);
//            ////myStreamWriter.Flush();
//            ////myStreamWriter.AutoFlush= true;
//            ////myStreamWriter.Close();
//            //process.WaitForExit();
//            //process.Close(); //.Dispose();  


//            //process.StandardInput.WriteLine();
//            //process.StandardInput.Write("q");

//            //process.StandardInput.Write("q" + process.StandardInput.NewLine);
//            //process.StandardInput.AutoFlush = true;

//            //process.WaitForExit();
//            //process.Close(); //.Dispose(); 

//            //StopScreenRecording();
//            process.Close();

//            //Stop();
//        }


//        public static void StopScreenRecording()
//        {
//            StreamWriter myStreamWriter = process.StandardInput; // this required to send StandardInput stream, nothing fancy 
//                                                                 // myStreamWriter.WriteLine("q"); //this will send q as an input to the ffmpeg process window making it stop , please cross check in task manager once if the ffmpeg is still running or closed.
//            string key = "q";
//            byte[] bytes = Encoding.ASCII.GetBytes(key);

//            //myStreamWriter.WriteLine(bytes); //,0, 1); //.UTF8);
//            process.StandardInput.WriteLine("q");
               
//        }


//        public void Stop()
//        {
//            string key = "q";
//            byte[] bytes = Encoding.ASCII.GetBytes(key);


//            var input = System.Text.Encoding.GetEncoding("gb2312").GetBytes(key);//.GetString(System.Text.Encoding.UTF8.GetBytes(key)); ;

//            //byte[] qKey = Encoding.GetEncoding("gbk").GetBytes("q"); //Get encoding of 'q' key

//            process.StandardInput.BaseStream.Write(input, 0, 1); //Write 'q' key to stdin of FFmpeg sub-processs
//            process.StandardInput.BaseStream.Flush(); //Flush stdin (just in case).
//            process.Close();
//        }





//        [Test]
//        //[Category("TestExample")]
//        public void Test1()
//        {
//            driver.Navigate().GoToUrl("https://www.google.com/");
//            Thread.Sleep(1500);
//            driver.FindElement(By.Name("q")).SendKeys("selenium\n");
//            Thread.Sleep(1500);


//        }
//    }
//}
