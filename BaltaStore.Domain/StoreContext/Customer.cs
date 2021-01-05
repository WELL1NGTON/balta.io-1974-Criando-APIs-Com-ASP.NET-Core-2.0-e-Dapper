using System;

namespace BaltaStore.Domain.StoreContext
{
    public class Customer
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public decimal Salary { get; private set; }

        // Metodos
        public void Register() { }

        //Eventos
        public void AoRegistrar() { }
    }
}