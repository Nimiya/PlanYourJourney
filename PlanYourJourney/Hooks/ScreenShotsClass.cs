using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace PlanYourJourney.Hooks
{
    public static class ScreenShotsClass
    {
        // Failed Test Screen capture
        public static void FailedTestCaptureScreenShot(string Scenario)
        {

            try
            {
                string currentPath = Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(currentPath);
                DirectoryInfo info = new DirectoryInfo(directory);
                string path = info.Parent.Parent.FullName;

                Console.WriteLine("Path=" + path);
                Screenshot dd = ((ITakesScreenshot)CustomBaseClass.MyDriver).GetScreenshot();
                string imagename = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
                string date = DateTime.Today.ToString("dd-MM-yyyy");

                string TestResultLocation = path + "/Test Outputs/Failed Tests " + date;

                if (Directory.Exists(TestResultLocation) == false)
                {
                    Directory.CreateDirectory(TestResultLocation);
                }
                string localPathName = TestResultLocation + "/" + Scenario;

                if (Directory.Exists(localPathName) == false)
                {
                    Directory.CreateDirectory(localPathName);
                }
                dd.SaveAsFile(localPathName + "/" + imagename + ".png", ScreenshotImageFormat.Png);
                CustomBaseClass.Thinktime(2);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed Screensots- failed ");
                Assert.Fail();
                DriverClass.CloseTest();
            }


        }
    }
}
