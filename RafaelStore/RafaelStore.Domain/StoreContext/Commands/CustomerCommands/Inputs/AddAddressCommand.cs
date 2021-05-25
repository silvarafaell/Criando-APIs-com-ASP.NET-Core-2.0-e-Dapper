using System;
using BaltaStore.Domain.StoreContext.Enums;
using FluentValidator;
using RafaelStore.Shared.Commands;

namespace RafaelStore.Domain.StoreContext.Commands.CustomerCommands.Inputs
{
    public class AddAdressCommand : Notifiable, ICommand
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public EAddressType Type { get; set; }
        public bool IsValid { get; private set; }

        bool ICommand.Valid()
        {
            return IsValid;
        }
    }
}