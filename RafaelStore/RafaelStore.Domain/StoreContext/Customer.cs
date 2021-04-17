using System;

namespace RafaelStore.Domain.StoreContext
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Adress { get; private set; }
    }
}