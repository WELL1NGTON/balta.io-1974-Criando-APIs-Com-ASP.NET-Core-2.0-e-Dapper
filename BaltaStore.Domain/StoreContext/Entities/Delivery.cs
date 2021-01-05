using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public DateTime CreatedDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public string Status { get; private set; }
    }
}