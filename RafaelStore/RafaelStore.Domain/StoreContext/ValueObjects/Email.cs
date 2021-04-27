using FluentValidator;
using FluentValidator.Validation;

namespace RafaelStore.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        //Construtor
        public Email(string adress)
        {
            Adress = adress;

            AddNotifications(new ValidationContract()
            .Requires()
            .IsEmail(Adress, "Email", "O e-mail é inválido")
            );

        }
        public string Adress { get; private set; }

        public override string ToString()
        {
            return Adress;
        }
    }
}