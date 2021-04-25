using Microsoft.VisualStudio.TestTools.UnitTesting;
using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.ValueObjects;

namespace RafaelStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Francisco", "Rafael");
            var document = new Document("12345678911");
            var email = new Email("francisco_rafael@hotmail.com.br");
            //Instancia do Objeto
            var c = new Customer(name, document, email, "85996029268");
            var mouse = new Product("Mouse", "Rato", "Image.png", 59.90M, 10);
            var teclado = new Product("Teclado", "Teclado", "Image.png", 159.90M, 10);
            var impressora = new Product("Impressora", "Impressora", "Image.png", 359.90M, 10);
            var cadeira = new Product("Cadeira", "Cadeira", "Image.png", 559.90M, 10);

            var order = new Order(c);
            order.AddItem(new OrderItem(mouse, 5));
            order.AddItem(new OrderItem(teclado, 5));
            order.AddItem(new OrderItem(cadeira, 5));
            order.AddItem(new OrderItem(impressora, 5));

            //Realizei o pedido
            order.Place();

            //Simular o pagamento
            order.Pay();

            //Simular o envio
            order.Ship();

            //Simular o cancelamento
            order.cancel();
        }
    }
}
