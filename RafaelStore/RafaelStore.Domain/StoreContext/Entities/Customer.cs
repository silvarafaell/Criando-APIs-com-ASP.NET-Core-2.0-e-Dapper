using System;
using System.Collections.Generic;
using RafaelStore.Domain.StoreContext.ValueObjects;

namespace RafaelStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        //construtor
        //SOLID
        public Customer(
            Name name,
            Document document,
            Email email,
            string phone
                      )
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            Addresses = new List<Address>();
        }

        //propriedades
        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses { get; private set; }

        //Sobreescrevendo
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}