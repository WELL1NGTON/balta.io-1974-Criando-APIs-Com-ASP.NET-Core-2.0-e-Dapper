using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Wellington", "Massola");
            var document = new Document("12345678911");
            var email = new Email("wellington@massola.com");
            var customer = new Customer(name, document, email, "1999207414");

            var mouse = new Product("Mouse", "Rato", "image.png", 59.90M, 10);
            var teclado = new Product("Teclado", "Teclado", "image.png", 159.90M, 10);
            var impressora = new Product("Impressora", "Produto que só dá problema", "image.png", 359.90M, 10);
            var cadeira = new Product("Cadeira", "Cadeira", "image.png", 559.90M, 10);

            var order = new Order(customer);
            // order.AddItem(new OrderItem(mouse, 5));
            // order.AddItem(new OrderItem(teclado, 5));
            // order.AddItem(new OrderItem(cadeira, 5));
            // order.AddItem(new OrderItem(impressora, 5));

            // Realizei o pedido
            order.Place();

            // Verificar se o pedido é valido
            var valid = order.IsValid;

            // Simular o pagamento
            order.Pay();

            // Simular o envio
            order.Ship();

            // Simular o cancelamento
            order.Cancel();
        }
    }
}
