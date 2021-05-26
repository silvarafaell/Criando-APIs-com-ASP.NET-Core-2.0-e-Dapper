using System.Collections.Generic;
using System.Linq;
using RafaelStore.Domain.StoreContext.ValueObjects;
using RafaelStore.Shared.Entities;

namespace RafaelStore.Domain.StoreContext.Entities
{
    public class Customer : Entity
    {
        //Lista Interna
        private readonly IList<Address> _addresses;

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
            _addresses = new List<Address>();
        }

        //propriedades
        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAdress(Address address)
        {
            _addresses.Add(address);
        }

        //Sobreescrevendo
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}