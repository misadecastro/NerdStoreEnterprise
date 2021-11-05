using NSE.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.Clientes.API.Application.Events
{
    public class ClienteRegistradoEvent: Event
    {
        public ClienteRegistradoEvent(Guid id, string nome, string email, string cpf)
        {
            AggregateId = Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
    }
}
