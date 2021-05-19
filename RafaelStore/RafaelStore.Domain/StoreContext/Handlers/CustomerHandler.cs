using System;
using FluentValidator;
using RafaelStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.ValueObjects;
using RafaelStore.Shared.Commands;

namespace RafaelStore.Domain.StoreContext.Handlers
{
    public class CustomerHandler :
    Notifiable,
    ICommandHandler<CreateCustomerCommand>,
    ICommandHandler<AddAdressCommand>
    {
        public ICommandResult Handle(CreateCustomerCommand command)
        {
            //Verificar se o CPF já existe na base

            //Verificar se o email já existe na base

            //criar os VOS
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);

            //Criar a identidade
            var customer = new Customer(name, document, email, command.Phone);

            //Validar entidades e VOS
            AddNotifications(name.Notifications);
            AddNotifications(document.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            //Persisitir o cliente

            //Enviar um email de boas vindas

            //retornar o resultado para a tela
            return new CreateCustomerCommandResult(Guid.NewGuid(), name.ToString(), email.Adress);
        }

        public ICommandResult Handle(AddAdressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}