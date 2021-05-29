using RafaelStore.Domain.StoreContext.services;

namespace RafaelStore.Tests
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            throw new System.NotImplementedException();
        }
    }
}
