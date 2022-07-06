using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace RestSharpAPI
{
    public class Report
    {
        ExtentTest test;
        ExtentReports extentReports;
        ExtentTest logger;

        public Report()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Users\chethan.v\source\repos\RestSharpAPI\Sample.html"); // ExtentHtmlReporter is a class in which we are providing the location for storing the report.
            extentReports = new ExtentReports(); // Its used to intialize the report
            extentReports.AttachReporter(htmlReporter); // Here we are attaching the report to ExtentHtmlReporter class.
        }

        public ExtentTest CreateTest()
        {
            test = extentReports.CreateTest("SampleTest"); // Here we are creating a report.
            return test;
        }

        public void Logger()
        {
            logger = test.Log(Status.Pass, "Logger Value"); // After creating the test we are going to add logger to validate the data which has come from the API & then we are going to validate them against the database.
        } // if both are equal we are going to pass the test case. 

        public void EndTest()
        {
            extentReports.Flush();
        }
    }
}
