using System;
using System.Collections.Generic;
using FluentValidator;
using FluentValidator.Validation;
using RafaelStore.Shared.Commands;

namespace RafaelStore.Domain.StoreContext.Commands.OrderCommands.Inputs
{
    public class PlaceOrderCommand : Notifiable, ICommand
    {
        public PlaceOrderCommand()
        {
            OrderItems = new List<OrderItemCommand>();
        }

        //Guid Id do Customer
        public Guid Customer { get; set; }
        public IList<OrderItemCommand> OrderItems { get; set; }
        public bool IsValid { get; private set; }

        public bool Valid()
        {
            AddNotifications(new ValidationContract()
                .HasLen(Customer.ToString(), 36, "Customer", "Identificador do Cliente inválido")
                .IsGreaterThan(OrderItems.Count, 0, "Items", "Nenhum item do pedido foi encontrado")
            );
            return IsValid;
        }
    }

    public class OrderItemCommand
    {
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }
    }
}