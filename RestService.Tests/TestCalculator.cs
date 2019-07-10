using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestService.Controllers;
using RestService.Helper;

namespace RestService.Tests
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAddMethod()
        {
            // Arrange
            var controller = new CalculatorController();
            controller.Request = new  HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            // Act
            JsonResult<RestResponse>response = controller.Add(12,20);
            // Assert
            Assert.AreEqual(response.Content.Result, 32);
        }

        [TestMethod]
        public  void TestDivideMethod()
        {
            // Arrange
            var controller = new CalculatorController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            // Act
            JsonResult<RestResponse> response =  controller.Divide(50, 2);
            // Assert
            Assert.AreEqual(response.Content.Result, 25);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            // Arrange
            var controller = new CalculatorController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            // Act
            JsonResult<RestResponse> response = controller.Multiply(50, 2);
            // Assert
            Assert.AreEqual(response.Content.Result, 100);
        }


        [TestMethod]
        public void TestSubtractMethod()
        {
            // Arrange
            var controller = new CalculatorController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            // Act
            JsonResult<RestResponse> response = controller.Subtract(50, 2);
            // Assert
            Assert.AreEqual(response.Content.Result, 48);
        }
    }
}
