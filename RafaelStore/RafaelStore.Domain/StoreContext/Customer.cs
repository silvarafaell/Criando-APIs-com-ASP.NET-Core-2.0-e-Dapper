using System;

namespace RafaelStore.Domain.StoreContext
{
    public class Customer
    {
        //Propriedades
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        //Metodos
        public void Register() { }

        //Eventos
        public void AoRegistrar() { }
    }
}