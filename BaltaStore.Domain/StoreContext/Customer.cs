using System;

namespace BaltaStore.Domain.StoreContext
{
    public interface IPerson
    {
        string Name { get; set; }
        DateTime BirthDate { get; set; }


        void OnRegister();
    }

    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
    }

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

    public class Salesman : IPerson
    {

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public void OnRegister()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}