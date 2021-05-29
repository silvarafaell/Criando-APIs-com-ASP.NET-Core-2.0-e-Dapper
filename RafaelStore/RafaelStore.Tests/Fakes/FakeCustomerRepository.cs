using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.Repositories;

namespace RafaelStore.Tests
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CkeckEmail(string email)
        {
            return false;
        }

        public void Save(Customer customer)
        {

        }
    }
}
