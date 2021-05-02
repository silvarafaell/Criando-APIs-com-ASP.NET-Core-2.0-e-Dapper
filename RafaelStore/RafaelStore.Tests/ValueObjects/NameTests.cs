using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RafaelStore.Tests
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsNotValid()
        {
            var name = new Name("", "Rafael");
            Assert.AreEqual(false, name.IsValid);
            Assert.AreEqual(1, name.Notifications.Count);
        }
    }
}