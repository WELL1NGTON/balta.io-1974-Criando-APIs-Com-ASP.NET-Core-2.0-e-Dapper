using System;

namespace BaltaStore.Domain.StoreContext
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }
        public decimal Salary { get; private set; }
    }
    public class Customer : Person
    {
        // Propriedades

        // Metodos
        public void Register() { }

        //Eventos
        public void AoRegistrar() { }
    }

    public class Salesman : Person
    {

    }

    public class Teste()
    {
        public Teste()
    {
        var c = new Person();

    }
}
}