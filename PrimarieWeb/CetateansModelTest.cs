using NUnit.Framework;
using PrimarieWeb.Models;

namespace PrimarieWeb.Tests.Models
{
    [TestFixture]
    public class CetateanTests
    {
        [Test]
        public void Cetatean_PropertyValidation()
        {
            // Arrange
            var cetatean = new Cetatean();

            // Act
            cetatean.CetateanId = 1;
            cetatean.nume = "John Doe";

            // Assert
            Assert.AreEqual(1, cetatean.CetateanId);
            Assert.AreEqual("John Doe", cetatean.nume);
        }

        [Test]
        public void Cetatean_RelationshipsValidation()
        {
            // Arrange
            var cetatean = new Cetatean();

            // Act
            cetatean.Eveniments = new List<Eveniment>();
            cetatean.Documents = new List<Document>();
            cetatean.Chats = new List<Chat>();

            // Assert
            Assert.IsNotNull(cetatean.Eveniments);
            Assert.IsNotNull(cetatean.Documents);
            Assert.IsNotNull(cetatean.Chats);
        }
    }
}
