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
    public class EvenimentsControllerTests
    {
        private EvenimentsController _controller;
        private Mock<IEvenimentService> _evenimentServiceMock;

        [SetUp]
        public void Setup()
        {
            _evenimentServiceMock = new Mock<IEvenimentService>();
            _controller = new EvenimentsController(_evenimentServiceMock.Object);
        }

        [Test]
        public void Index_ReturnsViewResultWithEveniments()
        {
            // Arrange
            var expectedEveniments = new List<Eveniment>
            {
                new Eveniment { EvenimentId = 1, numeEveniment = "Event 1" },
                new Eveniment { EvenimentId = 2, numeEveniment = "Event 2" }
            };
            _evenimentServiceMock.Setup(service => service.GetAll()).Returns(expectedEveniments);

            // Act
            var result = _controller.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = (ViewResult)result;
            Assert.AreEqual(expectedEveniments, viewResult.Model);
        }

        [Test]
        public void Create_ValidModel_RedirectsToIndex()
        {
            // Arrange
            var validEveniment = new Eveniment { EvenimentId = 1, numeEveniment = "Event 1" };

            // Act
            var result = _controller.Create(validEveniment);

            // Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
            var redirectResult = (RedirectToActionResult)result;
            Assert.AreEqual("Index", redirectResult.ActionName);
        }

        [Test]
        public void Create_InvalidModel_ReturnsViewResultWithModel()
        {
            // Arrange
            var invalidEveniment = new Eveniment { EvenimentId = 1, numeEveniment = "" };
            _controller.ModelState.AddModelError("Name", "The Name field is required.");

            // Act
            var result = _controller.Create(invalidEveniment);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = (ViewResult)result;
            Assert.AreEqual(invalidEveniment, viewResult.Model);
        }

    } 
}
