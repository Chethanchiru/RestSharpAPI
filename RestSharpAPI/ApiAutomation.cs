using System;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestSharpAPI
{
    [TestClass]
    public class ApiAutomation : Report
    {
        ExtentTest logger;

        [TestInitialize]
        public void Intialize()
        {
            this.logger = CreateTest();// CreateTest is going to create a report
        }

        [TestMethod]
        public void getMethodAPI()
        {
            RestClient client = new RestClient(); // RestClient & RestRequest are class which will accept api methods. And we should mention what type of method we are giving.
            //RestRequest request = new RestRequest("https://api.agify.io/?name=meelad", Method.Get); 
            RestRequest request = new RestRequest("https://catfact.ninja/fact", Method.Get); 
            request.AddHeader("Accept", "application/json");// we can configure what type of request do we want in request.AddHeader & also we can add configuration and authentication to it.
            var response = client.Execute(request);// After creating the request we will execute the response. And the response will have the content and status code in it.
            var contentVal = response.Content;
            Assert.IsNotNull(contentVal);
            Console.WriteLine(contentVal);
        }

        [TestCleanup]
        public void cleanUpTest()
        {
            EndTest();// Here we are closing the report
        }
    }
}

//https://apipheny.io/free-api/

//Doubts
// I'm getting response as null during dedugging.