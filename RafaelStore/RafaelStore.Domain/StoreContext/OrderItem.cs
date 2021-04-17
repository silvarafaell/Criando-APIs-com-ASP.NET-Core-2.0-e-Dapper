using System;

namespace RafaelStore.Domain.StoreContext
{
    public class OrderItem
    {
        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}