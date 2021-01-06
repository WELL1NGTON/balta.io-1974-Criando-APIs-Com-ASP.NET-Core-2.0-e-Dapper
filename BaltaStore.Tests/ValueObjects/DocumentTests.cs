using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {

        protected private Document validDocument;
        protected private Document invalidDocument;
        public DocumentTests()
        {
            validDocument = new Document("28659170377");
            invalidDocument = new Document("12345678910");
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotValid()
        {
            var document = invalidDocument;

            Assert.AreEqual(false, document.IsValid);
            Assert.AreEqual(1, document.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNoNotificationWhenDocumentIsValid()
        {
            var document = validDocument;

            Assert.AreEqual(true, document.IsValid);
            Assert.AreEqual(0, document.Notifications.Count);
        }
    }
}