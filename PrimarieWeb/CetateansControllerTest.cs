using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using PrimarieWeb.Controllers;
using PrimarieWeb.Models;
using PrimarieWeb.Services.Interfaces;
using System.Collections.Generic;

namespace PrimarieWeb.Tests.Controllers
{
    [TestFixture]
    public class CetateansControllerTests
    {
        private CetateansController _controller;
        private Mock<ICetateanService> _cetateanServiceMock;

        [SetUp]
        public void Setup()
        {
            _cetateanServiceMock = new Mock<ICetateanService>();
            _controller = new CetateansController(_cetateanServiceMock.Object);
        }

        [Test]
        public void Index_ReturnsViewResultWithCetateans()
        {
            // Arrange
            var expectedCetateans = new List<Cetatean>
            {
                new Cetatean { CetateanId = 1, nume = "John" },
                new Cetatean { CetateanId = 2, nume = "Jane" }
            };
            _cetateanServiceMock.Setup(service => service.GetAll()).Returns(expectedCetateans);

            // Act
            var result = _controller.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = (ViewResult)result;
            Assert.AreEqual(expectedCetateans, viewResult.Model);
        }

        [Test]
        public void Create_ValidModel_RedirectsToIndex()
        {
            // Arrange
            var validCetatean = new Cetatean { CetateanId = 1, nume = "John" };

            // Act
            var result = _controller.Create(validCetatean);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectResult = (RedirectToActionResult)result;
            Assert.AreEqual("Index", redirectResult.ActionName);
        }

        [Test]
        public void Create_InvalidModel_ReturnsViewResultWithModel()
        {
            // Arrange
            var invalidCetatean = new Cetatean { CetateanId = 1, nume = "" };
            _controller.ModelState.AddModelError("Name", "The Name field is required.");

            // Act
            var result = _controller.Create(invalidCetatean);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = (ViewResult)result;
            Assert.AreEqual(invalidCetatean, viewResult.Model);
        }

       
    }
}
