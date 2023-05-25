using NUnit.Framework;
using PrimarieWeb.Models;

namespace PrimarieWeb.Tests.Models
{
    [TestFixture]
    public class EvenimentTests
    {
        [Test]
        public void Eveniment_Initialization()
        {
            // Arrange
            int evenimentId = 1;
            string numeEveniment = "Test Event";
            string descriere = "This is a test event";
            var dataEveniment = new DateTime(2023, 1, 1);
            int cetateanId = 1;

            // Act
            var eveniment = new Eveniment
            {
                EvenimentId = evenimentId,
                numeEveniment = numeEveniment,
                descriere = descriere,
                dataEveniment = dataEveniment,
                CetateanId = cetateanId
            };

            // Assert
            Assert.AreEqual(evenimentId, eveniment.EvenimentId);
            Assert.AreEqual(numeEveniment, eveniment.numeEveniment);
            Assert.AreEqual(descriere, eveniment.descriere);
            Assert.AreEqual(dataEveniment, eveniment.dataEveniment);
            Assert.AreEqual(cetateanId, eveniment.CetateanId);
        }
    }
}
