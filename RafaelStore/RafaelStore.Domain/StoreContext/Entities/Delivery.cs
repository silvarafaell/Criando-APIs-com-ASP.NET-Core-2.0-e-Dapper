using System;
using RafaelStore.Domain.StoreContext.Enums;

namespace RafaelStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimateDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimateDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }
        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Ship()
        {
            //Se a Data estimada de entrega for no passado, não entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            //Se o status ja estiver entregue, não pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}