using System;

namespace RafaelStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public string Status { get; private set; }
    }
}