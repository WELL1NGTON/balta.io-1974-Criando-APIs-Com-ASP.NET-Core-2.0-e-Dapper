using System;
using System.Collections.Generic;
using BaltaStore.Domain.StoreContext.Enums;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Customer Customer { get; private set; }

        public Order(Customer customer)
        {
            Customer = customer;
        }

        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items { get; private set; }
        public IReadOnlyCollection<Delivery> Deliveries { get; private set; }

        public void AddItem(Order item)
        {
            // Valida item
            // Adiciona ao pedido
        }

        // To Place An Order
        public void Place() { }
    }
}