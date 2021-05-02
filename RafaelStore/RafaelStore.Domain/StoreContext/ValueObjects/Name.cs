using FluentValidator;
using FluentValidator.Validation;

namespace RafaelStore.Domain.StoreContext.ValueObjects
{
    public class Name : Notifiable
    {
        //Construtor
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(FirstName, 3, "FirstName", "O nome deve conter pelo menos 3 caracteres")
            .HasMaxLen(FirstName, 40, "FirstName", "O nome deve conter no máximo 40 caracteres")
            .HasMinLen(LastName, 3, "LastName", "O nome deve conter pelo menos 3 caracteres")
            .HasMaxLen(LastName, 40, "LastName", "O nome deve conter no máximo 40 caracteres")
            );
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool IsValid { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}