using System;
using BaltaStore.Domain.StoreContext.Enums;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreatedDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreatedDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }
    }
}