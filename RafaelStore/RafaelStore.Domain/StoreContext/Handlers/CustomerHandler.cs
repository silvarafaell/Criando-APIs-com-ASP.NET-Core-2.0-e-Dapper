using System;
using FluentValidator;
using RafaelStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using RafaelStore.Domain.StoreContext.Entities;
using RafaelStore.Domain.StoreContext.Repositories;
using RafaelStore.Domain.StoreContext.services;
using RafaelStore.Domain.StoreContext.ValueObjects;
using RafaelStore.Shared.Commands;

namespace RafaelStore.Domain.StoreContext.Handlers
{
    public class CustomerHandler :
    Notifiable,
    ICommandHandler<CreateCustomerCommand>,
    ICommandHandler<AddAdressCommand>
    {
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;

        public CustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CreateCustomerCommand command)
        {
            //Verificar se o CPF já existe na base
            if (_repository.CheckDocument(command.Document))
                AddNotification("Document", "Este CPF já esta em uso");
            //Verificar se o email já existe na base
            if (_repository.CkeckEmail(command.Email))
                AddNotification("Email", "Este E-mail já esta em uso");

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

            if (Invalid)
                return null;

            //Persisitir o cliente
            _repository.Save(customer);

            //Enviar um email de boas vindas
            _emailService.Send(email.Adress, "francisco_rafael@hotmail.com.br", "Bem vindo", "Seja bem vindo ao Rafael Store");

            //retornar o resultado para a tela
            return new CreateCustomerCommandResult(customer.Id, name.ToString(), email.Adress);
        }

        public ICommandResult Handle(AddAdressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}