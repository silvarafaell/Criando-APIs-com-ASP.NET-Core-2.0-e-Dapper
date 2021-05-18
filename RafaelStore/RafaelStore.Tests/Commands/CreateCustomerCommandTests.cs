using Microsoft.VisualStudio.TestTools.UnitTesting;
using RafaelStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.ValueObjects;

namespace RafaelStore.Tests
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Rafael";
            command.LastName = "Pereira";
            command.Document = "28659170377";
            command.Email = "francisco_rafael@hotmail.com.br";
            command.Phone = "85996029268";

            Assert.AreEqual(true, command.Valid());
        }
    }
}
