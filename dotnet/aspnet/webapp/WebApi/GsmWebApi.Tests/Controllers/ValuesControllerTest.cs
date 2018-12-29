using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GsmWebApi.Controllers;
using GsmWebApi.Models;
using GsmWebApi.Tests.Utilities;

using FluentAssertions;
using System.Net;
using System.Web.Http.Results;

namespace GsmWebApi.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void ValidateWebTestValid()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            VsWebTest vsWebTest = new VsWebTest
            {
                Id = "VSWebTestValid",
                TestIntervalInSeconds = 300,
                ApplicationId = "myapp",
                SubscriptionId = Guid.NewGuid(),
                InstrumentationKey = Guid.NewGuid(),
                Name = "sometest",
                IsRetryEnabled = true,
                ConfigXml = Utils.GetFileContents("ValidWebTest.xml")
            };

            // Act
            var result = controller.ValidateVsWebTest(vsWebTest);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }

        [TestMethod]
        public void ValidateWebTestInvalid()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            VsWebTest vsWebTest = new VsWebTest
            {
                Id = "VSWebTestValid",
                TestIntervalInSeconds = 300,
                ApplicationId = "myapp",
                SubscriptionId = Guid.NewGuid(),
                InstrumentationKey = Guid.NewGuid(),
                Name = "sometest",
                IsRetryEnabled = true,
                ConfigXml = Utils.GetFileContents("InvalidWebTest.xml")
            };

            // Act
            Action action = () => controller.ValidateVsWebTest(vsWebTest);

            // Assert
            var result = action.Should().Throw<HttpResponseException>();
            result.And.Response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void ValidateWebTestNullWebtest()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            var result = controller.ValidateVsWebTest(null);

            // Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
            var specificResult = result as BadRequestErrorMessageResult;
            Assert.AreEqual("No webtest found in the request body.", specificResult.Message);
        }

    }
}
