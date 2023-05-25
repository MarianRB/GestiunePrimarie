using NUnit.Framework;
using Moq;
using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;
using PrimarieWeb.Services;

namespace PrimarieWeb.Tests.Services
{
    [TestFixture]
    public class CetateanServiceTests
    {
        private CetateanService _cetateanService;
        private Mock<ICetateanRepository> _cetateanRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _cetateanRepositoryMock = new Mock<ICetateanRepository>();
            _cetateanService = new CetateanService(_cetateanRepositoryMock.Object);
        }

        [Test]
        public void GetById_ValidId_ReturnsCetatean()
        {
            // Arrange
            int cetateanId = 1;
            var expectedCetatean = new Cetatean { CetateanId = cetateanId };
            _cetateanRepositoryMock.Setup(r => r.GetById(cetateanId)).Returns(expectedCetatean);

            // Act
            var result = _cetateanService.GetById(cetateanId);

            // Assert
            Assert.AreEqual(expectedCetatean, result);
        }

        [Test]
        public void GetAll_ReturnsAllCetateans()
        {
            // Arrange
            var expectedCetateans = new List<Cetatean>
            {
                new Cetatean { CetateanId = 1 },
                new Cetatean { CetateanId = 2 }
            };
            _cetateanRepositoryMock.Setup(r => r.GetAll()).Returns((IQueryable<Cetatean>)expectedCetateans);

            // Act
            var result = _cetateanService.GetAll();

            // Assert
            Assert.AreEqual(expectedCetateans, result);
        }

        [Test]
        public void Add_ValidCetatean_CallsRepositoryAddAndSave()
        {
            // Arrange
            var cetatean = new Cetatean();

            // Act
            _cetateanService.Add(cetatean);

            // Assert
            _cetateanRepositoryMock.Verify(r => r.Add(cetatean), Times.Once);
            _cetateanRepositoryMock.Verify(r => r.Save(), Times.Once);
        }

        [Test]
        public void Update_ValidCetatean_CallsRepositoryUpdateAndSave()
        {
            // Arrange
            var cetatean = new Cetatean();

            // Act
            _cetateanService.Update(cetatean);

            // Assert
            _cetateanRepositoryMock.Verify(r => r.Update(cetatean), Times.Once);
            _cetateanRepositoryMock.Verify(r => r.Save(), Times.Once);
        }

        [Test]
        public void Delete_ValidCetatean_CallsRepositoryDeleteAndSave()
        {
            // Arrange
            var cetatean = new Cetatean();

            // Act
            _cetateanService.Delete(cetatean);

            // Assert
            _cetateanRepositoryMock.Verify(r => r.Delete(cetatean), Times.Once);
            _cetateanRepositoryMock.Verify(r => r.Save(), Times.Once);
        }
    }
}
