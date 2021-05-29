using Microsoft.VisualStudio.TestTools.UnitTesting;
using RafaelStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.Handlers;
using RafaelStore.Domain.StoreContext.ValueObjects;

namespace RafaelStore.Tests
{
    [TestClass]
    public class CustomerHandlerTests
    {
        [TestMethod]
        public void ShouldRegisterCustomerWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Rafael";
            command.LastName = "Pereira";
            command.Document = "28659170377";
            command.Email = "francisco_rafael@hotmail.com.br";
            command.Phone = "85996029268";

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());
            var result = handler.Handle(command);

            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(true, handler.Invalid);
        }
    }
}
