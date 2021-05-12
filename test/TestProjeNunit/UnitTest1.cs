using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WebapiTest;
using WebapiTest.Controllers;

namespace TestProjeNunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestController()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();  
            var controller = new WeatherForecastController(logger.Object); 
            IEnumerable<WeatherForecast> wvalues = controller.Get(); 
            Assert.AreEqual(wvalues.Count(),5);
        }
    }
}