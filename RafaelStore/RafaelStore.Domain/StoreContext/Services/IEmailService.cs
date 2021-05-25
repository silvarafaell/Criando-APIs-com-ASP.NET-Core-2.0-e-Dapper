using RafaelStore.Domain.StoreContext.Entities;

namespace RafaelStore.Domain.StoreContext.services
{
    public interface IEmailService
    {
        void Send(string to, string from, string subject, string body);
    }
}