using Microsoft.AspNetCore.Mvc;
using NSE.Clientes.API.Application.Commands;
using NSE.Clientes.API.Models;
using NSE.Core.Mediator;
using NSE.WebAPI.Core.Controllers;
using NSE.WebAPI.Core.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.Clientes.API.Controllers
{
    public class ClienteController : MainController
    {
        private readonly IMediatorHandler _mediator;
        private readonly IClienteRepository _clienteRepository;
        private readonly IAspNetUser _user;

        public ClienteController(IMediatorHandler mediatorHandler, IClienteRepository clienteRepository, IAspNetUser user)
        {
            _mediator = mediatorHandler;
            _clienteRepository = clienteRepository;
            _user = user;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var result = await _mediator.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(),"Misael de Castro", "misadecastro@gmail.com","07124431697"));
            return CustomResponse(result);
        }

        [HttpGet("cliente/endereco")]
        public async Task<IActionResult> ObterEndereco()
        {
            var endereco = await _clienteRepository.ObterEnderecoPorId(_user.ObterUserId());

            return endereco == null ? NotFound() : CustomResponse(endereco);
        }

        [HttpPost("cliente/endereco")]
        public async Task<IActionResult> AdicionarEndereco(AdicionarEnderecoCommand endereco)
        {
            endereco.ClienteId = _user.ObterUserId();

            return CustomResponse(await _mediator.EnviarComando(endereco));
        }
    }
}
