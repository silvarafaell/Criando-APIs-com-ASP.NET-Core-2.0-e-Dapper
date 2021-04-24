using Microsoft.VisualStudio.TestTools.UnitTesting;
using RafaelStore.Domain.StoreContext.Entities;

namespace RafaelStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Instancia do Objeto
            var c = new Customer();

            var order = new Order(c);
        }
    }
}
