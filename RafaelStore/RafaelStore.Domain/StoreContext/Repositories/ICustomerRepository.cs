using RafaelStore.Domain.StoreContext.Entities;

namespace RafaelStore.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
        bool CheckDocument(string document);
        bool CkeckEmail(string email);
        void Save(Customer customer);
    }
}