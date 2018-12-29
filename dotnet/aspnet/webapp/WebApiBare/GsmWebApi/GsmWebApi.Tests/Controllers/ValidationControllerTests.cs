using GsmWebApi.Controllers;
using GsmWebApi.Models;
using GsmWebApi.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Http.Results;

namespace GsmWebApi.Tests.Controllers
{
    [TestClass]
    public class ValidationControllerTests
    {
        [TestMethod]
        public void ValidateWebTestValid()
        {
            // Arrange
            ValidationController controller = new ValidationController();
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
    }
}
