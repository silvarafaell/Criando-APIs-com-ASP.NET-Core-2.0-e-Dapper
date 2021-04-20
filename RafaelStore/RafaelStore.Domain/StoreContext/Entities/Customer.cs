using System;

namespace RafaelStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        //construtor
        //SOLID
        public Customer(string firstName,
            string lastName,
            string document,
            string email,
            string phone,
            string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            Phone = phone;
            Adress = adress;
        }

        //propriedades
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Adress { get; private set; }

        //Sobreescrevendo
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}