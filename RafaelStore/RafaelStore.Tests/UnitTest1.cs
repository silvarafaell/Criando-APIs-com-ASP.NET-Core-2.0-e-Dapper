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
            var c = new Customer("Francisco", "Rafael", "12345678", "francisco_rafael@hotmail.com.br", "8596029268", "Rua dois n 101");

            var order = new Order(c);
        }
    }
}
