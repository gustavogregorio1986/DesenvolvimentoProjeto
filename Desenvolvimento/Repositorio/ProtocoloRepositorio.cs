using Desenvolvimento.Data;
using Desenvolvimento.Models;
using Desenvolvimento.Repositorio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Desenvolvimento.Repositorio
{
    public class ProtocoloRepositorio : IProtocoloRepositorio
    {
        private BancoContext _bancoContext;

        public ProtocoloRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ProtocoloModel Adiciona(ProtocoloModel protocolo)
        {
            _bancoContext.Protocolos.Add(protocolo);
            _bancoContext.SaveChanges();

            return protocolo;
        }

        public List<ProtocoloModel> ListarTodos()
        {
            return _bancoContext.Protocolos.ToList();
        }
    }
}
