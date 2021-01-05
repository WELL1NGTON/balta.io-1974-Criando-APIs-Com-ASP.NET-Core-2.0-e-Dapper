using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Status { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public IList<Delivery> Deliveries { get; private set; }

        // To Place An Order
        public void Place() { }
    }
}