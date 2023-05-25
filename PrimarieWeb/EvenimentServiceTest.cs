using Moq;
using NUnit.Framework;
using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;
using PrimarieWeb.Services;

namespace PrimarieWeb.Tests.Services
{
    [TestFixture]
    public class EvenimentServiceTests
    {
        private EvenimentService _evenimentService;
        private Mock<IEvenimentRepository> _evenimentRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _evenimentRepositoryMock = new Mock<IEvenimentRepository>();
            _evenimentService = new EvenimentService(_evenimentRepositoryMock.Object);
        }

        [Test]
        public void GetById_WithValidId_ReturnsEveniment()
        {
            // Arrange
            int evenimentId = 1;
            var expectedEveniment = new Eveniment { EvenimentId = evenimentId };

            _evenimentRepositoryMock.Setup(repo => repo.GetById(evenimentId))
                .Returns(expectedEveniment);

            // Act
            var result = _evenimentService.GetById(evenimentId);

            // Assert
            Assert.AreEqual(expectedEveniment, result);
        }

        [Test]
        public void Add_ValidEveniment_CallsRepositoryAddAndSave()
        {
            // Arrange
            var eveniment = new Eveniment();

            // Act
            _evenimentService.Add(eveniment);

            // Assert
            _evenimentRepositoryMock.Verify(repo => repo.Add(eveniment), Times.Once);
            _evenimentRepositoryMock.Verify(repo => repo.Save(), Times.Once);
        }

        
    }
}
