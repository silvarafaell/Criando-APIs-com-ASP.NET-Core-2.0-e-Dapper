using System;
using System.Collections.Generic;

namespace RafaelStore.Domain.StoreContext.Commands.OrderCommands.Inputs
{
    public class PlaceOrderCommand
    {
        //Guid Id do Customer
        public Guid Customer { get; set; }
        public IList<OrderItemCommand> OrderItems { get; set; }
    }

    public class OrderItemCommand
    {
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }
    }
}