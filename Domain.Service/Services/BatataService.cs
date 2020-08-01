using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Interfaces.Repositories;
using Domain.Model.Interfaces.Services;

namespace Domain.Service.Services
{
    public class BatataService : IBatataService
    {
        private readonly IBatataRepository _batataRepository;

        public BatataService(
            IBatataRepository batataRepository)
        {
            _batataRepository = batataRepository;
        }

        public string VenderBatata(int quantidade)
        {
            var quantidadeEstoque = _batataRepository.ObterQuantidade();

            var quantidadeVendida = quantidadeEstoque >= quantidade
                ? quantidade
                : quantidadeEstoque;

            _batataRepository.ReduzirQuantidade(quantidadeVendida);

            return "Olá da Batata assada x" + quantidadeVendida;
        }
    }
}
